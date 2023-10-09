using System.IO;
using System.Text;
using System;

namespace Jaeger.SAT.CFDI.Consulta {
    internal class Log {
        public static void Escribir(string Texto, string stackTrace) {
            string logfileName = $"jaeger_sat_consulta_{DateTime.Now:dd_MM_yyyy}.txt";
            string logfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logfileName);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Concat(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), " : ", Texto));
            stringBuilder.AppendLine(stackTrace);
            using (StreamWriter streamWriter = new StreamWriter(logfile, true)) {
                streamWriter.Write(stringBuilder.ToString());
            }
        }
    }
}
