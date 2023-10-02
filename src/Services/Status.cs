using System.Threading.Tasks;
using Jaeger.SAT.CFDI.Consulta.Abstracts;
using Jaeger.SAT.CFDI.Consulta.Entities;
using Jaeger.SAT.CFDI.Consulta.Interfaces;

namespace Jaeger.SAT.CFDI.Consulta.Services {
    public class Status : ServiceCFDI, IStatus {
        public Status() : base("https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc") {
        }

        public string Version {
            get { return "1.4"; }
        }

        public override async Task<Acuse> ExecuteAsync(IRequest request) {
            return await this.ConsultaCFDIServiceAsync(this.GetExpresionImpresa(request));
        }

        public override Acuse Execute(IRequest request) {
            return this.Request(request.EmisorRFC, request.ReceptorRFC, request.Total, request.FolioFiscal);
        }

        /// <summary>
        /// servicio de consulta de CFDI´s
        /// </summary>
        /// <param name="emisorRFC">RFC del emisor</param>
        /// <param name="receptorRFC">RFC del receptor</param>
        /// <param name="total">total del importe del comprobante</param>
        /// <param name="folioFiscal">UUID</param>
        /// <returns>objeto Acuse</returns>
        public Acuse Execute(string emisorRFC, string receptorRFC, decimal total, string folioFiscal) {
            return this.Request(emisorRFC, receptorRFC, total, folioFiscal);
        }

        public IResponse Execute1(IRequest request) {
            var d0 = this.Request(request.EmisorRFC, request.ReceptorRFC, request.Total, request.FolioFiscal);
            IResponse response = new Response().WithAcuse(d0).WithVersion(this.Version).WithMessage(this.Message(d0.CodigoEstatus));
            return response;
        }

        public async Task<IResponse> Execute2(IRequest request) {
            var d0 = await this.ConsultaCFDIServiceAsync(this.GetExpresionImpresa(request));
            IResponse response = new Response().WithAcuse(d0).WithVersion(this.Version).WithMessage(this.Message(d0.CodigoEstatus));
            return response;
        }

        public string Message(string codigo) {
            if (string.IsNullOrEmpty(codigo))
                return string.Empty;
            var s1 = int.Parse(codigo);
            
            return this.Message(s1);
        }

        public string Message(int codigo) {
            var d0 = new Messages();
            return d0.GetCodigo(codigo);
        }
    }
}
