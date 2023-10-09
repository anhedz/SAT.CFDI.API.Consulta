﻿using Jaeger.SAT.CFDI.API.Consulta;

namespace Jaeger.SAT.CFDI.Consulta.Interfaces {
    public interface IResponse {

        string Version { get; }

        IAcuse Acuse { get; set; }

        string Message { get; }

        IResponse WithVersion(string version);

        IResponse WithAcuse(Acuse acuse);

        IResponse WithMessage(string message);
    }
}
