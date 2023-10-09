using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Jaeger.SAT.CFDI.API.Consulta {

    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class ConsultaCFDIServiceClient : ClientBase<IConsultaCFDIService>, IConsultaCFDIService {

        public ConsultaCFDIServiceClient() { }

        public ConsultaCFDIServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        public ConsultaCFDIServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public ConsultaCFDIServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public ConsultaCFDIServiceClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        public Acuse Consulta(string expresionImpresa) {
            return base.Channel.Consulta(expresionImpresa);
        }

        public Task<Acuse> ConsultaAsync(string expresionImpresa) {
            return base.Channel.ConsultaAsync(expresionImpresa);
        }
    }
}
