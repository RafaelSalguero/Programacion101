Nota: este archivo se puede leer mejor en google chrome utilizando la extensión markdown reader

##Programación orientada a objetos
En los lenguajes modernos de programación existe el concepto de **objeto**, existen diferentes
conceptos formales sobre la definición de un objeto y sobre sus propiedades tales como
encapsulación, poliformismo, herencia, etc... pero en resumen es una entidad que:

 - Es capaz de almacenar información en sus **campos**
 - Es capaz de ejecutar código de sus **métodos**

###Identidad de un objeto

A diferencia de los los valores, los objetos viven en un espacio de memoria 
especial llamado `HEAP`, al cual las variables hacen referencia.

Entendemos entonces que ninguna variable es capaz de almacenar un objeto, si no que las
variables almacenan *referencias* a los objetos existentes.

Este concepto es importante ya que nos permite entender que no importa que tantas veces este
presente un objeto en el código, este objeto sera siempre el mismo.

Al hecho de que un objeto siempre sera el mismo objeto sin importar que tantas veces sea
manipulado o asignado se le conoce como **identidad**.

###Creación de un objeto
En C#, los objetos son creados con el operador `new` seguido del tipo del objeto y de
los parametros de su **constructor**.

El **constructor** es el primer metodo ejecutado en la vida de todos los objetos, y esta
encargado de inicializar al objeto en el momento de su creación.

**Ejemplo:**
```
class Persona {
    //El constructor de la clase persona nos obliga a establecer un Nombre y Apellido al
    //crear un objeto de este tipo. En C#, el constructor es una función con el 
    //mismo nombre que la clase
    public Persona(string Nombre, string Apellido) {
        //El objeto actual se referencia con la palabra clave this

        //Aqui asignamos los campos del objeto igual a los parametros del constructor
        this.Nombre = Nombre;
        this.Apellido = Apellido;
    }

    string Nombre;
    string Apellido;
}

//Hemos creado un nuevo objeto, y la variable ejemplo apunta a este;
Persona ejemplo = new Persona("Rafael", "Salguero");

//Ahora existen dos variables que apuntan al mismo objeto
Persona laMismaPersona = ejemplo;
```

###Clases y objeto
Una clase es la definición de que campos, propiedades y métodos tendran los objetos de este tipo.

###Responsabilidades de las clases
Algo importante al crear nuevas clases es tener en cuenta su responsabilidad. Las clases deben de tener 
un propósito bien definido y no tener código que se encargue de realizar ninguna función mas que para la cual
fueron diseñadas.

Esto implica que en lugar de tener pocas clases que hagan muchas cosas los buenos programas estan formados de 
muchas pequeñas clases, cada una con cierta función en el programa.

###Algunos tipos de clases
Aunque uno puede diseñar una clase de cualquier manera que se le ocurra y esto es válido, en la práctica
existen diferentes patrones que son útiles para resolver una gran cantidad de problemas comunes en 
los programas comerciales.

Algunos de estos son:

 - **Clase de "entidad" o "DTO (Data transfer object)**
    - Son clases que tienen ningúno o muy pocos métodos y que su único propósito es almacenar información que 
    lógicamente debe de permanecer junta. Por ejemplo, la clase `Persona` se puede considerar un DTO ya que no
    tiene ninguna función mas que la de agrupar el `Nombre` y el `Apellido`.

    En los programas comerciales se utilizan principalmente para el acceso a las bases de datos, ya que las tablas
    de pueden ser representadas por clases que tengan una propiedad para cada columna de las tablas

- **Clases de lógica**
