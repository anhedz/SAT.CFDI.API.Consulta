using System.Collections.Generic;
using Jaeger.SAT.CFDI.Properties;

namespace Jaeger.SAT.CFDI.Consulta.Services {
    internal class Messages {
        readonly Dictionary<int, string> messages = new Dictionary<int, string>();
        public Messages() {
            this.messages.Add(100, Resources.msg_100);

            this.messages.Add(101, @"El RFC emisor y algún RFC a cuenta de terceros de la factura verificada, se encuentran publicados en la lista de empresas que facturan operaciones simuladas de conformidad con los párrafos primero al quinto del artículo 69-b del CFF.
Consulta aquí la fecha en que se publicó la empresa en el listado de definitivas. Recuerda que, de conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes. Para mayor información ingresa aquí.");

            this.messages.Add(102, @"El RFC a cuenta de terceros de la factura verificada, se encuentran publicados en la lista de empresas que facturan operaciones simuladas de conformidad con los párrafos primero al quinto del artículo 69-b del CFF.
Consulta aquí la fecha en que se publicaron las empresas en el listado de definitivas. Recuerda que, de conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.
Para mayor información ingresa aquí.");

            this.messages.Add(103, @"Para el supuesto en que tenga varios RFC relacionados a cuenta de terceros:
Alguno de los RFC a cuenta de terceros de la factura verificada, se encuentra publicado en la lista de empresas que facturan operaciones simuladas de conformidad con los párrafos primero al quinto del artículo 69-b del CFF.
Consulta aquí la fecha en que se publicaron las empresas en el listado de definitivas. Recuerda que, de conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.
Para mayor información ingresa aquí");

            this.messages.Add(104, @"Para el supuesto en que tenga varios RFC relacionados a cuenta de terceros:
El RFC del emisor y alguno de los RFC a cuenta de terceros de la factura verificada, se encuentran publicados en la lista de empresas que facturan operaciones simuladas de conformidad con los párrafos primero al quinto del artículo 69-b del CFF.
Consulta aquí la fecha en que se publicaron las empresas en el listado de definitivas. Recuerda que, de conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.
Para mayor información ingresa aqu");
        }

        public string GetCodigo(int id) {
            if (id == 100 | id == 101 | id == 102 | id == 103 | id == 104)
                return messages[id];
            return "No definido";
        }
    }
}
