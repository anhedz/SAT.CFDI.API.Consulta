using System.Threading.Tasks;
using Jaeger.SAT.CFDI.API.Consulta;

namespace Jaeger.SAT.CFDI.Consulta.Interfaces {
    public interface IStatus {
        /// <summary>
        /// version de libreria
        /// </summary>
        string Version { get; }

        Acuse Execute(IRequest request);

        Task<Acuse> ExecuteAsync(IRequest request);

        /// <summary>
        /// servicio de consulta de CFDI´s
        /// </summary>
        /// <param name="emisorRFC">RFC del emisor</param>
        /// <param name="receptorRFC">RFC del receptor</param>
        /// <param name="total">total del importe del comprobante</param>
        /// <param name="folioFiscal">UUID</param>
        /// <returns>objeto Acuse</returns>
        Acuse Execute(string emisorRFC, string receptorRFC, decimal total, string folioFiscal);

        string Message(int codigo);
    }
}
