using Jaeger.SAT.CFDI.Consulta.Interfaces;

namespace Jaeger.SAT.CFDI.Consulta.Builder {
    public interface IRequestReceptorRFCBuilder {
        /// <summary>
        /// obtener o establecer RFC del receptor del comprobante
        /// </summary>
        IRequestTotalBuilder WithReceptorRFC(string receptorRFC);
    }

    public interface IRequestTotalBuilder {
        /// <summary>
        /// obtener o establecer el total de comprobante
        /// </summary>
        IRequestFolioFiscalBuilder WithTotal(decimal total);

        /// <summary>
        /// obtener o establecer el total de comprobante
        /// </summary>
        IRequestFolioFiscalBuilder WithTotal(string total);
    }

    public interface IRequestFolioFiscalBuilder {
        /// <summary>
        /// obtener o establecer folio fiscal (UUID)
        /// </summary>
        IRequestCreateBuilder WithFolioFiscal(string uuid);
    }

    public interface IRequestCreateBuilder {
        /// <summary>
        /// crear objeto
        /// </summary>
        IRequest Build();
    }

    public interface IRequestBuilder {
        /// <summary>
        /// obtener o establecer RFC del emisor del comprobante
        /// </summary>
        IRequestReceptorRFCBuilder WithEmisorRFC(string rfCEmisor);
    }
}
