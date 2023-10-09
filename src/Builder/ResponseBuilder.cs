using Jaeger.SAT.CFDI.Consulta.Interfaces;
using Jaeger.SAT.CFDI.API.Consulta;

namespace Jaeger.SAT.CFDI.Consulta.Builder {
    public class ResponseBuilder : IResponseBuilder, IResponseWithMessageBuilder, IResponseWithVersionBuilder, IResponseBuild {
        private readonly IResponse _Response;

        /// <summary>
        /// constructor
        /// </summary>
        internal ResponseBuilder() {
            this._Response = new Response();
        }

        public IResponseWithMessageBuilder WithAcuse(IAcuse acuse) {
            this._Response.Acuse = acuse;
            return this;
        }

        public IResponseWithVersionBuilder WithMessage(string message) {
            this._Response.WithMessage(message);
            return this;
        }

        /// <summary>
        /// establecer version del servicio
        /// </summary>
        public IResponseBuild WithVersion(string version) {
            this._Response.WithVersion(version);
            return this;
        }

        /// <summary>
        /// retornar objeto creado
        /// </summary>
        public IResponse Build() {
            return _Response;
        }
    }
}
