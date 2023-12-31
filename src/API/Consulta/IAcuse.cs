﻿using System.Runtime.Serialization;

namespace Jaeger.SAT.CFDI.API.Consulta {
    public interface IAcuse {
        string CodigoEstatus { get; set; }
        string EsCancelable { get; set; }
        string Estado { get; set; }
        string EstatusCancelacion { get; set; }
        ExtensionDataObject ExtensionData { get; set; }
        string ValidacionEFOS { get; set; }
    }
}
