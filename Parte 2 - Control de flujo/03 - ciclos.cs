//****************************
//Ciclos
//****************************

/*
Un ciclo es una forma de repetir el mismo bloque de código
*/

//*******************************
//while - Ejecuta un bloque de codigo siempre que se cumpla una **expresión booleana**
//*******************************

//Ejemplos:

//Este programa nunca termina. Escribe hola muchas veces en la consola
while(true) {
    Console.WriteLine("hola");
}

while(false) {
    //Esta linea NO es ejecutada
    Console.WriteLine("hola");
}

//Este programa escribe 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

//Note el primer y el ultimo valor que escribe:
//Primero escribe 1, no 0. - 
//          Aunque la variable inicia en 0, vemos que el incremento esta *antes* del Console.WriteLine, por lo que en este punto para la
//          primera iteración el valor ya vale uno

//Al final termina en 10, no en 9 ni en 11
//          Cuando contador vale 9, se le suma 1 y escribe en la consola 10,
//          La siguiente iteracion no se cumple ya que la expresion contador < 10 devuelve falso cuando contador == 10 (10 < 10 es falso)

int contador = 0;
while(contador < 10) {
    contador = contador + 1;
    Console.WriteLine(contador);
}


//Este programa escribe 0, 2, 4, 6, 8

//Note el primer y ultimo valor que escribe
//A diferencia del programa anterior, primero escribe 0, no 1
//          Esto es porque ahora el incremento esta *despues*


int contador = 0;
while(contador < 10) {
    if(contador % 2 == 0) {
        //Solo escribe el numero si es divisible entre 2 (Es un numero par)
        Console.WriteLine(contador);
    }
    contador = contador + 1;
}
