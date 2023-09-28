using System;
using System.ServiceModel;
using System.Net;

namespace Jaeger.SAT.CFDI.Consulta.Abstracts {
    public abstract class ServiceBase {
        #region declaraciones
        private readonly string urlService;
        #endregion

        /// <summary>
        /// URL del servicio
        /// </summary>
        public string Url {
            get { return this.urlService; }
        }

        /// <summary>
        /// constructor
        /// </summary>
        internal ServiceBase(string url) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            this.urlService = url; 
        }

        /// <summary>
        /// configuracion del servicio
        /// </summary>
        public BasicHttpBinding GetBinding() {
            var binding = new BasicHttpBinding {
                ReceiveTimeout = new TimeSpan(0, 1, 0),
                SendTimeout = new TimeSpan(0, 5, 0),
                OpenTimeout = new TimeSpan(0, 5, 0),
                CloseTimeout = new TimeSpan(0, 5, 0),
                MaxReceivedMessageSize = 2147483647,
                BypassProxyOnLocal = true,
                UseDefaultWebProxy = true
            };
            binding.Security.Mode = Url.StartsWith("https") ? BasicHttpSecurityMode.Transport : BasicHttpSecurityMode.None;
            return binding;
        }
    }
}
