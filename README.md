# falabella
Exámen falabella
Aca se encuentran los archivos de las preguntas del exémen:
III.- Prueba de Automatización Funcional:
Automatizar la prueba funcional del flujo:
Archivo para ejecutar en selenium IDE = Automatizacion_Militzai.side
Archivo test no terminado en C# = ADDProductTest
IV.- Prueba de Automatización API:
Automatizar los métodos de la siguiente API https://api.github.com/gists
Método GET:
https://api.github.com/gists/{id}
Crear las siguientes afirmaciones (Assertions):

Código de respuesta
Archivo= Examen Mili.postman_test_run1

Método GET:
https://api.github.com/gists/{id}/comments
Crear las siguientes afirmaciones (Assertions):

Estado de respuesta
Que la respuesta tien un body JSON válido
Que el tiempo de respuesta sea menor a 500ms
Archivo= Examen Mili.postman_test_run2

Método POST:
https://api.github.com/gists/{id}/comments
{
"body": ""
}
Crear las siguientes afirmaciones (Assertions):

Verificar si el estado del Post fue exitosa o no
Si la respuesta tiene un body JSON válido
Archivo= Examen Mili.postman_test_run3

Collections de Postman= Examen Mili.postman_collection
Saludos,
Militzai
