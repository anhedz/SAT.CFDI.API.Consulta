using Jaeger.SAT.CFDI.Consulta.Builder;
using Jaeger.SAT.CFDI.Consulta.Interfaces;

namespace Jaeger.SAT.CFDI.Consulta {
    public class Request : IRequest {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IRequestBuilder Create() {
            return new RequestBuilder();
        }

        /// <summary>
        /// constructor
        /// </summary>
        public Request() { }

        /// <summary>
        /// obtener o establecer RFC del emisor del comprobante
        /// </summary>
        public string EmisorRFC { get; set; }

        /// <summary>
        /// obtener o establecer RFC del receptor del comprobante
        /// </summary>
        public string ReceptorRFC { get; set; }

        /// <summary>
        /// obtener o establecer el total de comprobante
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// obtener o establecer folio fiscal (UUID)
        /// </summary>
        public string FolioFiscal { get; set; }
    }
}
