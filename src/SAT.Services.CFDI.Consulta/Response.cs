using Jaeger.SAT.CFDI.Consulta.Interfaces;
using Jaeger.SAT.CFDI.Consulta.Entities;
using Jaeger.SAT.CFDI.Consulta.Builder;

namespace Jaeger.SAT.CFDI.Consulta {
    public class Response : IResponse {
        #region declaraciones
        private string _Version = string.Empty;
        private string _Message = string.Empty;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public Response() { }

        public static IResponseBuilder Create() {
            return new ResponseBuilder();
        }

        #region propiedades
        public string Version {
            get {
                return this._Version;
            }
        }

        public IAcuse Acuse { get; set; }

        public string Message {
            get {
                return _Message;
            }
        }
        #endregion

        #region build creacion
        public IResponse WithAcuse(Acuse acuse) {
            this.Acuse = acuse;
            return this;
        }

        public IResponse WithMessage(string message) {
            this._Message = message;
            return this;
        }

        public IResponse WithVersion(string version) {
            this._Version = version;
            return this;
        }
        #endregion
    }
}
