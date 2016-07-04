/**
¿Que es el flujo?

El flujo es el orden en el que se ejecutan las instrucciones, este flujo se representa por un
**puntero de programa**, este nos lo podemos imaginar como una flecha que recorre cada linea de código,
la cual indica cual es la siguiente instrucción que se debe de ejecutar

El puntero de programa o "PC" (por sus siglas en ingles Program Counter) tiende a incrementar con el tiempo a menos que sea
alterado por el programador 
}

¿Que el es control de flujo?

Son las herramientas del lenguaje que nos permiten modificar el PC para alterar el orden de
las instrucciones que se van a ejecutar.

Esto nos permite ejecutar pedazos de codigo de manera condicional, crear ciclos, y llamar a funciones  
*/

//*********************************
//if - Ejecuta condicionalmente un bloque de codigo, dependiendo del valor de una **expresión booleana**
//*********************************

//Ejemplos:

//Este programa SIEMPRE escribe hola en la consola
if(true) {
    Console.WriteLine ("hola");
}

//Este programa NUNCA escribe hola en la consola
if(false) {
    Console.WriteLine("hola");
}

//Este programa SIEMPRE escribe hola en la consola
if(true || false) {
    Console.WriteLine("hola");
}

//Este programa escribe Quiceañera cuando edad es igual a 15
int edad;
if(edad == 15) {
    Console.WriteLine ("Quinceañera");
}

//*********************************
//else - Ejecuta un bloque de codigo cuando NO se cumple un if
//*********************************

//Este programa escribe Quiceañera cuando edad es igual a 15, si no, escribe No hay fiesta
int edad;
if(edad == 15) {
    Console.WriteLine ("Quinceañera");
} else {
    Console.WriteLine ("No hay fiesta");
}

//Determina si una persona puede trabajar, si tiene 18 o mas o menos de 65 años
if(edad >= 18 && edad < 65) {
    Console.WriteLine("Edad laboral");
} else {
    Console.WriteLine("No puede trabajar");
}