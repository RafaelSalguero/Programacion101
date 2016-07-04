//***************************************
//Recorrer un arreglo
//***************************************

/*
Recorrer un arreglo implica ejecutar un bloque de codigo para *cada uno de sus elementos* independientemente de la cantidad
de elementos que existan en el mismo.

Esta es una de las operaciones mas comunes en la programación ya que la gran mayoria de los datos en los programas estan almacenados
en arreglos.
*/

//Utilizando el ciclo while

//Recordando al ciclo while, que ejecuta un bloque siempre que se cumpla una condicion, 
//la logica aqui es incrementar una variable hasta que sea igual a la longitud del arreglo

//generalmente las letra "i" se usan para representar a los indices

int[] edades = new int[] { 10, 20, 30, 40, 50 };

//Escribe cada una de las edades en la consola: 
int i = 0;
while(i < edades.Length) {
    Console.WriteLine(edades[i]);
    i = i + 1;
}

//Utilizando el ciclo for
//El ciclo for se usa cuando se quiere combinar un while con una variable que se esta incrementando, es una manera
//mas fácil y rápida de escribir el mismo código y por lo mismo se prefiere por sobre el while, aunque hacen exactamente lo mismo

//Note que la variable puede ser definida en el mismo for (int i = 0; i < length; i++)
//El for tiene 3 partes:
//Inicializacion.- Establece el valor inicial de la variable, es equivalente al código que esta antes de inicar el while
//Condicion.- Expresión booleana que sera evaluada *antes* de cada iteración, es equivalente a la condición en el while
//Incremento.- Instrucción que sera ejecutada **después** de cada iteración, es equivalente al incremento al final del while


for(int i = 0; i < edades.Length; i++) { 
    Console.WriteLine(edades[i]);
}


//Utilizar el ciclo foreach

//El foreach es una instrucción especial que itera sobre cualquier colección de valores, este no expone el indice si no 
//el elemento del arreglo, debido a su sencillez es preferido por sobre el ciclo for, a menos que sea necesario usar un indice,
//en ese caso mejor utilizamos un for (int i = 0; i < length; i++)
foreach(int edad in edades) {
    Console.WriteLine(edad);
}

//El ciclo foreach itera sobre cualquier objeto que implemente la interfaz IEnumerable o IEnumerable<T>, los arreglos son un 
//tipo especial que implementa esta interfaz pero luego veremos que hay otros tipos que tambien pueden ser iterados, tales como
//las listas, colas, colecciones, incluso los datos obtenidos de una base de datos