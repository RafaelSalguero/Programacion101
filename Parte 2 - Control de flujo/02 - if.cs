//****************************
//else if
//****************************
/*
Ejecuta un bloque de codigo si NO se cumple el bloque if o else if anterior, Y si se cumple una condición booleana
*/ 

//Ejemplos:

if(true){
    //Esta linea SIEMPRE se ejecuta
    Console.WriteLine("Hola");
} else if (true) {
    //Esta linea NUNCA se ejecuta      
    Console.WriteLine("Adios");
}


int edad;

//Determina si la persona es un niño, señor o muchacho
if(edad < 15) {
    //Se ejecuta si la edad es mejor que 15
    Console.WriteLine("Es un niño");
} else if (edad > 40) {
    //Si el bloque anterior no se cumple, se ejecuta si la edad es mayor que 40
    Console.WriteLine("Es un señor");
} else {
    //Si ningun bloque anterior se ejectua, este se ejecuta
    Console.WriteLine("Es un muchacho");
}