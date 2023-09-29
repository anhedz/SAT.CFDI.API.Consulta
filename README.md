# SAT.Services.CFDI.Consulta

El Servicio de consulta de CFDI´s se diseñó para permitir la validación accediendo a 
un servicio publicado en la página del SAT, el servicio pretende proveer una 
alternativa de consulta que requiera verificar el estado de un comprobante en las 
Bases de Datos del SAT

# Mensajes de Respuesta 
Los mensajes de respuesta que arroja el servicio de consulta de CFDI´s incluyen la 
descripción del resultado de la operación que corresponden a la siguiente 
clasificación: 
Mensajes de Rechazo. 
N 601: La expresión impresa proporcionada no es válida. 
Este código de respuesta se presentará cuando la petición de validación no se haya 
respetado en el formato definido. 
N 602: Comprobante no encontrado. 
Este código de respuesta se presentará cuando el UUID del comprobante no se 
encuentre en la Base de Datos del SAT.
Mensajes de Aceptación. 
S Comprobante obtenido satisfactoriamente. 
Mensajes de validación del RFC Emisor
Código= 100 
Este código de respuesta se presentará cuando la validación del RFC Emisor del CFDI
se encuentre dentro de la lista de Empresa que Factura Operaciones Simuladas
(EFOS), por lo tanto, los usuarios finales lo deberán relacionar al siguiente mensaje: 
El emisor de la factura verificada se encuentra publicado en la lista 
de empresas que facturan operaciones simuladas de conformidad 
con los párrafos primero al quinto del Artículo 69-B del CFF.
Consulta aquí la fecha en que se publicó la empresa en el listado de 
definitivas. Recuerda que, de conformidad con lo dispuesto por el 
octavo párrafo del artículo 69-B del CFF, si eres el receptor del 
comprobante consultado y le has dado efectos fiscales, cuentas con 
30 días contados a partir de la fecha de publicación en la lista, para 
comprobar ante el SAT la realización de las operaciones que 
amparan los citados comprobantes fiscales, o bien puedes en el 
mismo plazo, corregir tu situación fiscal mediante la presentación de 
las declaraciones complementarias que correspondan, para no 
considerar esos comprobantes.
