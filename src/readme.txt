Revisión: 2.0.0.0 | Marzo 2023
Servicio de Consulta de CFDI (Versión 1.4)

// instanciar servicio
IStatus serviceSAT = new Status();

// Build request
IRequest request = SAT.Consulta.Request.Create()
                    .WithEmisorRFC(emisor)
                    .WithReceptorRFC(receptor)
                    .WithTotal(total)
                    .WithFolioFiscal(idDocumento)
                    .Build()

 IResponse = response = this.serviceSAT.Execute(
                SAT.Consulta.Request.Create()
                .WithEmisorRFC(emisor)
                .WithReceptorRFC(receptor)
                .WithTotal(total)
                .WithFolioFiscal(idDocumento)
                .Build());


** Mensajes de Rechazo. 
N 601: La expresión impresa proporcionada no es válida. 
    Este código de respuesta se presentará cuando la petición de validación no se haya respetado en el 
    formato definido. 

N 602: Comprobante no encontrado. 
    Este código de respuesta se presentará cuando el UUID del comprobante no se encuentre en la Base de 
    Datos del SAT.

Mensajes de Aceptación. 
    S Comprobante obtenido satisfactoriamente. 

** Mensajes de validación del RFC Emisor

- Código= 100 
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI se encuentre dentro 
de la lista de Empresa que Factura Operaciones Simuladas (EFOS), por lo tanto, los usuarios finales lo 
deberán relacionar al siguiente mensaje: 

El emisor de la factura verificada se encuentra publicado en la lista de empresas que facturan operaciones 
simuladas de conformidad con los párrafos primero al quinto del Artículo 69-B del CFF.

Consulta aquí la fecha en que se publicó la empresa en el listado de definitivas. Recuerda que, de 
conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del 
comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha 
de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los 
citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la 
presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.
 
Para mayor información ingresa aquí.
 
- Código= 101
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI se encuentre dentro 
de la lista de Empresa que Factura Operaciones Simuladas(EFOS), además alguno de los RFC a cuenta de 
terceros fue encontrado en la lista de Empresa que Factura Operaciones Simuladas (EFOS), por lo tanto, 
los usuarios finales lo deberán relacionar al siguiente mensaje:

El RFC emisor y algún RFC a cuenta de terceros de la factura verificada, se encuentran publicados en la 
lista de empresas que facturan operaciones simuladas de conformidad con los párrafos primero al quinto 
del artículo 69-b del CFF.

Consulta aquí la fecha en que se publicó la empresa en el listado de definitivas. Recuerda que, de 
conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del 
comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha 
de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los 
citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la 
presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.

Para mayor información ingresa aquí.

- Código= 102
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI no se encuentre 
dentro de la lista de Empresa que Factura Operaciones Simuladas (EFOS), y adicionalmente se tiene un RFC 
a cuenta de terceros que fue encontrado en la lista de Empresa que Factura Operaciones Simuladas (EFOS), 
por lo tanto, los usuarios finales lo deberán relacionar al siguiente mensaje:

El RFC a cuenta de terceros de la factura verificada, se encuentran publicados en la lista de empresas 
que facturan operaciones simuladas de conformidad con los párrafos primero al quinto del artículo 69-b 
del CFF.

Consulta aquí la fecha en que se publicaron las empresas en el listado de definitivas. Recuerda que, de 
conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del 
comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha 
de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los 
citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la 
presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.

Para mayor información ingresa aquí.

- Código= 103
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI no se encuentre 
dentro de la lista de Empresa que Factura Operaciones Simuladas (EFOS), y adicionalmente alguno de los 
RFC a cuenta de terceros fue encontrado en la lista de Empresa que Factura Operaciones Simuladas (EFOS), 
por lo tanto, los usuarios finales lo deberán relacionar al siguiente mensaje:

Para el supuesto en que tenga varios RFC relacionados a cuenta de terceros:

Alguno de los RFC a cuenta de terceros de la factura verificada, se encuentra publicado en la lista de 
empresas que facturan operaciones simuladas de conformidad con los párrafos primero al quinto del 
artículo 69-b del CFF.

Consulta aquí la fecha en que se publicaron las empresas en el listado de definitivas. Recuerda que, de 
conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del 
comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha 
de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los 
citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la 
presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.

Para mayor información ingresa aquí.
 
- Código= 104
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI se encuentre dentro 
de la lista de Empresa que Factura Operaciones Simuladas (EFOS), además alguno de los RFC a cuenta de 
terceros fue encontrado en la lista de Empresa que Factura Operaciones Simuladas (EFOS), por lo tanto, 
los usuarios finales lo deberán relacionar al siguiente mensaje:

Para el supuesto en que tenga varios RFC relacionados a cuenta de terceros:

El RFC del emisor y alguno de los RFC a cuenta de terceros de la factura verificada, se encuentran 
publicados en la lista de empresas que facturan operaciones simuladas de conformidad con los párrafos 
primero al quinto del artículo 69-b del CFF.

Consulta aquí la fecha en que se publicaron las empresas en el listado de definitivas. Recuerda que, de 
conformidad con lo dispuesto por el octavo párrafo del artículo 69-B del CFF, si eres el receptor del 
comprobante consultado y le has dado efectos fiscales, cuentas con 30 días contados a partir de la fecha 
de publicación en la lista, para comprobar ante el SAT la realización de las operaciones que amparan los 
citados comprobantes fiscales, o bien puedes en el mismo plazo, corregir tu situación fiscal mediante la 
presentación de las declaraciones complementarias que correspondan, para no considerar esos comprobantes.

Para mayor información ingresa aquí.
URL de los Vínculos:
http://omawww.sat.gob.mx/cifras_sat/Paginas/datos/vinculo.html?page=ListCompleta69B.html
https://www.sat.gob.mx/consultas/76675/consulta-la-relacion-de-contribuyentes-que-realizan-operaciones-inexistentes

- Código=200
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI no se encuentre 
dentro de la lista de Empresa que Factura Operaciones Simuladas (EFOS).

- Código=201
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI y ninguno de los RFC 
A cuenta de terceros se encuentre dentro de la lista de Empresa que Factura Operaciones Simuladas (EFOS).


Esta librería contiene objetos de ayuda para crear expresiones de CFDI 3.2, CFDI 3.3, CFDI 4.0, RET 1.0 y RET 2.0 de acuerdo a la información técnica del SAT en el Anexo 20.

Estas expresiones se utilizan principalmente para dos motivos:

Generar el código QR de una representación impresa de un CFDI o RET.
Consultar el WebService del SAT de estado de un CFDI.

Ejemplo de expresión para CFDI 3.3 y CFDI 4.0:

Estas especificaciones comparten el mismo estándar.

https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id=CEE4BE01-ADFA-4DEB-8421-ADD60F0BEDAC&re=POT9207213D6&rr=DIM8701081LA&tt=2010.01&fe=/OAgdg==
Ejemplo de expresión para CFDI 3.2:

?re=AAA010101AAA&rr=COSC8001137NA&tt=0000001234.567800&id=CEE4BE01-ADFA-4DEB-8421-ADD60F0BEDAC
Ejemplo de expresión para RET 1.0:

?&re=XAXX010101000&nr=12345678901234567890%tt=1234567890.123456&id=ad662d33-6934-459c-a128-BDf0393f0f44
Ejemplo de expresión para RET 2.0:

https://prodretencionverificacion.clouda.sat.gob.mx/?id=AAAAAAAA-BBBB-CCCC-DDDD-000000000000&re=Ñ&amp;A010101AAA&nr=0000000000000000000X&tt=123456.78&fe=qsIe6w==