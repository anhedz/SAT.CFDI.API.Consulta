using Jaeger.SAT.CFDI.API.Consulta;
using Jaeger.SAT.CFDI.Consulta.Interfaces;

namespace Jaeger.SAT.CFDI.Consulta.Builder {
    public interface IResponseBuilder {
        IResponseWithMessageBuilder WithAcuse(IAcuse acuse);
    }

    public interface IResponseWithMessageBuilder {
        IResponseWithVersionBuilder WithMessage(string message);
    }

    public interface IResponseWithVersionBuilder {
        IResponseBuild WithVersion(string message);
    }

    public interface IResponseBuild {
        IResponse Build();
    }
}
