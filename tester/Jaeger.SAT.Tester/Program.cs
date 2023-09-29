using System;
using Jaeger.SAT.CFDI.Consulta.Interfaces;
using Jaeger.SAT.CFDI.Consulta.Services;

namespace Jaeger.SAT.Tester {
    internal class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("** SERVICIO DE CONSULTA ");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();

            Status service = new Status();

            // Build request
            IRequest request = CFDI.Consulta.Request.Create()
                                .WithEmisorRFC("SOC190205N7A")
                                .WithReceptorRFC("DCM1203237I0")
                                .WithTotal(10)
                                .WithFolioFiscal("F9A186DA-BDD4-494C-AA1E-A41C926808AC")
                                .Build();

            var response = service.Execute(request);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(response.CodigoEstatus);
            Console.WriteLine("Respuesta: \r\n" + response.EsCancelable);
            Console.ReadLine();
        }
    }
}
