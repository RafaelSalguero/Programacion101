//Examen:

static void main() {
    //No modifique este codigo:

    int a = 5;
    int b = 2;

    //Apartir de aqui puede modificar el código:
      

    //Escriba un programa que invierta los valores de las variables,
    //Por ejemplo

    //Si a vale 10, y b vale 20, al finalizar el programa a debe de valer 20 y b debe de valer 10

    //Si a = 3, y b = 4
    //al finalizar debe de quedar
    //   a = 4  y b = 3
    int x;
    x = a;
    a = b;
    b = x;
    
   
 
}

//Otro examen:
/**
Esta funcion toma las 3 longitudes de los lados de un triangulo, y determina si es un triangulo o no.

Para saber si es un triangulo se deben de cumplir las 3 condiciones:
a + b > c
a + c > b
b + c > a

Si solo una de las condiciones no se cumple, no es un triangulo.

Ejemplo.
Los lados 3, 4, 5 SI forman un triangulo (rectangulo)
Los lados 3, 4, 10 NO forman un triangulo
Los lados 3, 3, 3 SI forman un triangulo (equilatero)


*/
static bool EsTriangulo(int a, int b, int c)
 {
     bool c1,c2,c3;
     c1 = a + b > c;
     c2 = a + c > b;
     c3 = b + c > a;
     
     return  c1 && c2 && c3;
 }