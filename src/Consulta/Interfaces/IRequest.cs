namespace Jaeger.SAT.CFDI.Consulta.Interfaces {
    /// <summary>
    /// Peticion
    /// </summary>
    public interface IRequest {
        /// <summary>
        /// obtener o establecer RFC del emisor del comprobante
        /// </summary>
        string EmisorRFC { get; set; }

        /// <summary>
        /// obtener o establecer RFC del receptor del comprobante
        /// </summary>
        string ReceptorRFC { get; set; }

        /// <summary>
        /// obtener o establecer el total de comprobante
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        /// obtener o establecer folio fiscal (UUID)
        /// </summary>
        string FolioFiscal { get; set; }
    }
}
