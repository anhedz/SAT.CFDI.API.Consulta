using System;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.ComponentModel;

namespace Jaeger.SAT.CFDI.API.Consulta {
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContractAttribute(Name = "Acuse", Namespace = "http://schemas.datacontract.org/2004/07/Sat.Cfdi.Negocio.ConsultaCfdi.Servicio")]
    [SerializableAttribute()]
    public partial class Acuse : object, IExtensibleDataObject, INotifyPropertyChanged, IAcuse {

        [NonSerializedAttribute()]
        private ExtensionDataObject extensionDataField;

        [OptionalFieldAttribute()]
        private string CodigoEstatusField;

        [OptionalFieldAttribute()]
        private string EsCancelableField;

        [OptionalFieldAttribute()]
        private string EstadoField;

        [OptionalFieldAttribute()]
        private string EstatusCancelacionField;

        [OptionalFieldAttribute()]
        private string ValidacionEFOSField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }

        [DataMemberAttribute()]
        public string CodigoEstatus {
            get {
                return this.CodigoEstatusField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoEstatusField, value) != true)) {
                    this.CodigoEstatusField = value;
                    this.RaisePropertyChanged("CodigoEstatus");
                }
            }
        }

        [DataMemberAttribute()]
        public string EsCancelable {
            get {
                return this.EsCancelableField;
            }
            set {
                if ((object.ReferenceEquals(this.EsCancelableField, value) != true)) {
                    this.EsCancelableField = value;
                    this.RaisePropertyChanged("EsCancelable");
                }
            }
        }

        [DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }

        [DataMemberAttribute()]
        public string EstatusCancelacion {
            get {
                return this.EstatusCancelacionField;
            }
            set {
                if ((object.ReferenceEquals(this.EstatusCancelacionField, value) != true)) {
                    this.EstatusCancelacionField = value;
                    this.RaisePropertyChanged("EstatusCancelacion");
                }
            }
        }

        [DataMemberAttribute()]
        public string ValidacionEFOS {
            get {
                return this.ValidacionEFOSField;
            }
            set {
                if ((object.ReferenceEquals(this.ValidacionEFOSField, value) != true)) {
                    this.ValidacionEFOSField = value;
                    this.RaisePropertyChanged("ValidacionEFOS");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
