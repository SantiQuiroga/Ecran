# Miembros de Clase:

- **Fields (Campos)**: Son variables que se declaran directamente en la clase, pero fuera de cualquier método. Estos campos pueden ser utilizados por todos los métodos de la clase. En tu código, `_ecran`, `_engine` y `_control` son campos.

- **Constructor**: Es un método especial de una clase que se utiliza para inicializar objetos de esa clase. Se llama automáticamente cuando se crea un objeto. En tu código, `ElectricEcran(byte width, byte height)` es un constructor.

- **Métodos**: Son funciones que pertenecen a una clase. Pueden tener parámetros y un valor de retorno. En tu código, `ShowEcran()`, `HideEcran()` y `ClearLastLine()` son métodos.

- **Propiedades**: Son miembros que proporcionan un mecanismo flexible para leer, escribir o calcular el valor de un campo privado. Las propiedades pueden ser de lectura-escritura, solo lectura o solo escritura. No se observan propiedades en tu código.

- **Finalizador**: Es un método especial que se utiliza para liberar los recursos no administrados utilizados por tu aplicación. En C#, los finalizadores se definen utilizando el destructor `~ClassName()`. No se observa un finalizador en tu código.

- **Indicador (Indexer)**: Es un miembro que permite a los objetos de una clase ser indexados como si fueran arrays. No se observa un indicador en tu código.

- **Operador**: Los operadores son métodos especiales que definen acciones para los operadores de lenguaje como +, -, *, /, etc. No se observa una sobrecarga de operador en tu código.
