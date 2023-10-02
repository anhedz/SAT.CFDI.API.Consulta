using System;
using Jaeger.SAT.CFDI.Consulta.Builder;
using Jaeger.SAT.CFDI.Consulta.Interfaces;

namespace Jaeger.SAT.CFDI.Consulta {
    /// <summary>
    /// Builder
    /// </summary>
    public class RequestBuilder : IRequestBuilder, IRequestReceptorRFCBuilder, IRequestTotalBuilder, IRequestFolioFiscalBuilder, IRequestCreateBuilder {
        protected internal IRequest request;

        internal RequestBuilder() {
            this.request = new Request();
        }

        public IRequest Build() {
            return request;
        }

        /// <summary>
        /// Agregar RFC del emisor
        /// </summary>
        public IRequestReceptorRFCBuilder WithEmisorRFC(string rfc) {
            if (string.IsNullOrEmpty(rfc))
                throw new ArgumentNullException("El rfc del Emisor es requerido");
            this.request.EmisorRFC = rfc.ToUpper().Trim();
            return this;
        }

        /// <summary>
        /// Agregar RFC del receptor
        /// </summary>
        public IRequestTotalBuilder WithReceptorRFC(string rfc) {
            if (string.IsNullOrEmpty(rfc))
                throw new ArgumentNullException("El rfc del Receptor es requerido");
            this.request.ReceptorRFC = rfc.ToUpper().Trim();
            return this;
        }

        /// <summary>
        /// Establecer total del comprobante
        /// </summary>
        public IRequestFolioFiscalBuilder WithTotal(decimal total) {
            this.request.Total = total;
            return this;
        }

        /// <summary>
        /// Establecer el importe total del comprobante
        /// </summary>
        public IRequestFolioFiscalBuilder WithTotal(string total) {
            if (string.IsNullOrEmpty(total))
                throw new ArgumentNullException("El total es requerido");
            this.request.Total = decimal.Parse(total);
            return this;
        }

        /// <summary>
        /// Establecer folio fiscal (UUID)
        /// </summary>
        /// <param name="uuid">[\da-fA-F]{8}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{12}</param>
        public IRequestCreateBuilder WithFolioFiscal(string uuid) {
            if (string.IsNullOrEmpty(uuid)) 
                throw new ArgumentNullException("El uuid de la factura es requerido");
            this.request.FolioFiscal = uuid.ToUpper().Trim();
            return this;
        }
    }
}
