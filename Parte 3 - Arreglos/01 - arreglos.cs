//************************************************
//Arreglos
//************************************************

/*
Un arreglo es un tipo especial, el cual sirve para almacenar una *coleccion ordenada* de valores de cierto tipo

por ejemplo el tipo:
*/
int[]

/*
es un arreglo de numeros enterios

La variable:

*/
int[] edades;
/*
Puede almacenar no una, si no cero, una o muchas edades

Cada dato en el arreglo se conoce como *elemento*
Cualquier tipo puede ser el tipo de elemento de un arreglo, incluso otros arreglos:

Esta variable es un arreglo de un arreglo de un arreglo de numeros enteros
*/
int[][][] variable;
/*

Los arreglos al igual que las variables se pueden asignar:
*/

int[] edades;

//se asigna la variable edades a un nuevo arreglo de enteros con ciertos valores:
edades = new int[] { 20, 25, 23, 50, 40 };

//asigna edades a un arreglo vacio de 10 elementos (todos los elementos valdran 0 inicialmente)
edades = new int[10];

//************************************************
//Manipular un arreglos
//************************************************

//Los arreglos NO pueden modificar su tamaño una vez que fueron creados, esto quiere decir que si un arreglo fue creado para almacenar 3 elementos
//este arreglo jamas podra almacenar mas o menos elementos, la unica forma de cambiar esto es crear un nuevo arreglo con un tamaño diferente

//Un arreglo tiene *longitud* - La cantidad de elementos que hay en el arreglo
//Ejemplo:
edades = new int[] { 10, 20, 30 };
//Escribe 3 en la consola
Console.WriteLine(edades.Length);

//************************************************
//Elementos de un arreglo
//************************************************

//Nos podemos imaginar a los elementos de un arreglo como variables, que en lugar de tener un nombre tienen un indice,
//podemos hacer uso de los elementos en expresiones y de asignarlos a valores al igual que con cualquier otra variable

//Los elementos de un arreglo se pueden acceder **por indice**
//El indice es un numero que indica una posición en un arreglo, y comienzan en 0

edades = new int[] { 10, 20, 30 };
int primeraEdad = edades[0];
//primeraEdad vale 10

//Esto ocasiona un error en tiempo de ejecución, ya que el indice 3 no existe en el arreglo edades (va del 0 al 2)
int error = edades[3];

//El arreglo edades es [10, 20, 30]
edades[2] = 5;

//Ahora el arreglo de edades es [10, 20, 5]


//************************************************
//Indices dinámicos
//************************************************

//El indice de un arreglo no tiene que ser una constante necesariamente, cualquier expresion que devuelva un entero 
//puede ser usada como indice:

//El arreglo edades es [10, 20, 30]
edades[1 + 1] = 25;
//Ahora el arreglo de edades es [10, 20, 25]

int x = 0;

Console.WriteLine(edades[x]); //Escribe 10
x = x + 1; 

Console.WriteLine(edades[x]); //Escribe 20
x = x + 1;

Console.WriteLine(edades[x]); //Escribe 25
x = x + 1;