// Los mensajes de respuesta que arroja el servicio de consulta de CFDI´s incluyen la descripción del resultado de la operación que corresponden a la siguiente 
// clasificación: 
// Mensajes de Rechazo. 
//  N 601: La expresión impresa proporcionada no es válida. Este código de respuesta se presentará cuando la petición de validación no se haya respetado en el formato definido. 
//  N 602: Comprobante no encontrado. Este código de respuesta se presentará cuando el UUID del comprobante no se encuentre en la Base de Datos del SAT.
// Mensajes de Aceptación. 
//  S Comprobante obtenido satisfactoriamente.
using System;
using System.ServiceModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Net;
using System.Net.Security;
using Jaeger.SAT.CFDI.API.Consulta;
using Jaeger.SAT.CFDI.Consulta.Interfaces;

namespace Jaeger.SAT.CFDI.Consulta.Abstracts {
    public abstract class ServiceCFDI : ServiceBase {
        #region declaraciones
        private static BasicHttpBinding _binding;
        protected static int intentosMax = 3;
        protected static string expresionImpresa = "?re={0}&rr={1}&tt={2}&id={3}";
        #endregion

        protected ServiceCFDI(string url) : base(url) {
            ServicePointManager.ServerCertificateValidationCallback =
               delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            _binding = GetBinding();
        }

        public abstract Acuse Execute(IRequest request);

        public abstract Task<Acuse> ExecuteAsync(IRequest request);

        internal virtual string GetExpresionImpresa(string rfcEmisor, string rfcReceptor, decimal Total, string uuid) {
            var consulta = string.Format(expresionImpresa,
                rfcEmisor.ToUpper().Replace("&", "&amp;"),
                rfcReceptor.ToUpper().Replace("&", "&amp;"),
                Total.ToString("0.00"),
                uuid.ToUpper().Trim());
            return consulta;
        }

        internal virtual string GetExpresionImpresa(IRequest request) {
            return this.GetExpresionImpresa(request.EmisorRFC, request.ReceptorRFC, request.Total, request.FolioFiscal);
        }

        internal virtual Acuse Request(string rfcEmisor, string rfcReceptor, decimal Total, string uuid) {
            Acuse acuse = null;

            for (int intento = 0; intento < intentosMax; intento++) {
                acuse = ConsultaCFDIService(this.GetExpresionImpresa(rfcEmisor, rfcReceptor, Total, uuid));
                if (acuse != null)
                    break;
            }
            return acuse;
        }

        internal Acuse ConsultaCFDIService(string consulta) { 
            try {
                using (var client = new ConsultaCFDIServiceClient(_binding, new EndpointAddress(this.Url))) {
                    return client.Consulta(consulta);
                }
            } catch (Exception ex) {
                Console.WriteLine("[SAT.Consulta.CFDI] " + ex.Message);
                Log.Escribir("SAT.Consulta.CFDI", ex.StackTrace);
                throw ex;
            }
        }

        internal Task<Acuse> ConsultaCFDIServiceAsync(string consulta) {
            try {
                using (var client = new ConsultaCFDIServiceClient(_binding, new EndpointAddress(this.Url))) {
                    return client.ConsultaAsync(consulta);
                }
            } catch (Exception ex) {
                Console.WriteLine("[SAT.Consulta.CFDI] " + ex.Message);
                Log.Escribir("SAT.Consulta.CFDI", ex.StackTrace);
            }
            return null;
        }
    }
}
