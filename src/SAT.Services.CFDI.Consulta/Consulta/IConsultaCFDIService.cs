using System.Threading.Tasks;
using System.ServiceModel;
using System.CodeDom.Compiler;
using Jaeger.SAT.CFDI.Consulta.Entities;

namespace Jaeger.SAT.CFDI.Consulta.Interfaces {
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(ConfigurationName = "IConsultaCFDIService")]
    internal interface IConsultaCFDIService {

        [OperationContractAttribute(Action = "http://tempuri.org/IConsultaCFDIService/Consulta", ReplyAction = "http://tempuri.org/IConsultaCFDIService/ConsultaResponse")]
        Acuse Consulta(string expresionImpresa);

        [OperationContractAttribute(Action = "http://tempuri.org/IConsultaCFDIService/Consulta", ReplyAction = "http://tempuri.org/IConsultaCFDIService/ConsultaResponse")]
        Task<Acuse> ConsultaAsync(string expresionImpresa);
    }
}
