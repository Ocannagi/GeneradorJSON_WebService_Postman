App de Escritorio desarrollada en WindowsForms C# que devuelve un JSON con distintas variables ya seteadas para ser utilizadas en los Test de una Colección de Postman.
Todo ello dentro del marco de un WebService que fue creado para el proyecto de "Acta Digital Única" (ADU) de la Superintendencia de Riesgos del Trabajo.

Según las necesidades del usuario, el JSON devuelto puede ser un objeto a ser utilizado como variables de Colección de manera local en Postman, o bien,
puede ser un array de objetos a ser utilizado como variables de Iteración para usar en el Run Collection de Postman o por consola con Newman.

Por cuestiones de confidencialidad, no se adjunta la Colección de Postman que consume el JSON.

Ténganse en cuenta que la aplicación está pensada para ser usada por el equipo de QA. Por lo tanto, no hay validaciones en los distintos campos de la aplicación,
de modo tal que los testers puedan generar variables inválidas a propósito.

