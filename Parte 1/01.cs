//Variables

/*Las variables son una parte fundamental de todos los programas ya que es la unica forma que tiene la computadora
de almacenar información

En C#, todas las variables tienen un *nombre* y un *tipo* el cual determina que valores puede tomar una variable.

Los *tipos primitivos* son aquellos que vienen incluidos en el mismo C#, despues veremos que nosotros podemos
definir nuestros propios tipos


Algunos tipos primitivos son:

int - Entero con signo de 32 bits - Sirve para almacenar numeros enteros, hay otros tipos para almacenar enteros
aunque como regla general siempre que ocupemos un entero usamos este tipo para evitar problemas de conversión de tipos

string - Cadena de caracteres - Almacena texto, lo podemos imaginar como una colección ordenada de caracteres, donde un
caracter puede ser una letra, un numero, un espacio, signos de puntuación, etc... 

bool - Booleano - Almacena variables que solo toman dos valores, *true* o *false*. Este tipo de variables es muy importante
ya que nos permite representar *decisiones* 
*/ 

//**************************************************************************************************

/**
Expresiones

Son instrucciones que operan sobre las variables, funciones y tipos que se tienen disponible en la
parte del codigo donde estamos escribiendo.

Despues veremos que en diferentes lugares del codigo se puede acceder a ciertas variables

Las expresiones son *evaluadas* al ser ejecutadas, devolviendo un *resultado*

El resultado de una expresión puede ser usado para crear otras expresiones, para almacenarlo en una variable,
o en muchos otros lugares donde se espera una expresión. Por ejemplo


5 + 5

Es una expresión, se dice que es *constante* porque su resultado no depende de ninguna variable, por lo que siempre
resulta en lo mismo, que es 10

En cambio:

5 + x
(Suponiendo que x es una variable de tipo int)

Es una expresión que no es constante, ya que su valor varia segun el valor de x

Las expresiones, al igual que las variables, tambien tienen un *tipo* el cual depende de que resulte una expresión.

Por ejemplo, la expresión:

a + b

Seria de tipo int (numerico) si tanto *a* como *b* fueran int, pero si *a* y *b* fueran de tipo *string*
esta expresión, tambien seria de tipo *string*

Otro ejemplo:

a > 10

Si consideramos que a es de tipo *int*, esta expresión seria de tipo *bool*, ya que estamos usando el operador *mayor que*
el cual compara dos numeros y devuelve *true* si el primer numero es mayor que el segundo, si no, devuelve *false* 

Los operadores y su significado de C# tales como + - / * > < >= <= == ! &&, ||, etc... se encuentran en 
https://msdn.microsoft.com/en-us/library/6a71f45d.aspx

*/
public static Program {
    public static void main() {
        //Definir una variable:
        int edad = 20;

        //Asignar una variable, note que asignar una variable toma una expresión del lado derecho:
        edad = 30;

        //La expresión 10 + 10 sera evaluada, por lo que despues de esta linea de codigo, edad valdra 20
        edad = 10 + 10;

        //Esta linea como podemos ver no hace nada, ya que la expresión edad devolvera el valor de la misma edad
        //el cual sera asignado a la misma variable, por lo que seguira valiendo lo mismo, que es 20
        edad = edad;


        
        //**********************************
        //¿Como funciona la asignación?

        //La asignación de una variable es un proceso de 2 pasos
        //1.- Se evalua la expresión que se tiene en el lado derecho
        //2.- Despues de evaluar la expresión, se sustituye el valor de la variable con el resultado del paso anterior
        //**********************************

        //Esto se conoce como *incremento*, a una variable se le asigna el mismo valor de la variable mas uno
        //Como podemos ver, 1.- primero se evalua la expresión, que en este caso sera 21, despues a edad se le asigna
        //ese valor que es 21
        edad = edad + 1;

        //Despues de cada uno de estos pasos, edad valdra uno mas que el paso anterior,

        //Esta comentado el valor de la variable *despues* de haber ejecutado la linea de codigo
        edad = edad + 1; //22
        edad = edad + 1; //23
        edad = edad + 1; //24
        edad = edad + 1; //25


        //Ejemplos de expresiones booleanas

        //Las expresiones booleanas constan de operadores de **comparasión** y de **operadores lógicos**

        //¿Que es una comparación?
        //Es determinar si se cumplen o no relaciones entre valores. 

        //Estas son las siguientes comparaciones que podemos hacer:
        /* == Igualdad
                Determina si dos valores son exactamente iguales. Por ejemplo 20 == 20 devuelve *true*, pero 
                20 == 21 devuelve **false**

                21 == (20 + 1) devuelve **true**

                20 == edad devuelve **true** si edad es 20, si no, devuelve **false**

                20 == (edad / 2) devuelve **true** si edad es 40 o 41
            
            > Mayor que
                Determina si el valor de la izquierda es mayor que el de la derecha

                20 > 10 devuelve **true**
                20 > 20 devuelve **false**

            < Menor que
            >= Mayor o igual que    
            <= Menor o igual que
        */


        bool condicion;
        //Checamos si la edad es 25, en este caso si lo es, asi que condición valdra **true**
        condicion = edad == 25;

        //La variable la podemos asignar tambien directamente en su misma definición,
        bool EsMayorDeEdad = edad >= 18;

        //Si la edad es mayor de 40, EsUnSeñor es true
        bool EsUnSeñor;
        EsUnSeñor = edad > 40;


        //Si la edad es menor que 15, decimos que es un niño,
        bool EsUnNiño = edad < 15;

        //
        //*****************************************
        //Operadores lógicos   
        //*****************************************
        /*
        Estos nos sirven para manipular expresiones booleanas, los operadores booleanos toman expresiones booleanas
        y devuelven expresiones booleanas.

        Estos son los operadores booleanos:

        !   Negación

            Invierte el valor de una expresion booleana
            Por ejemplo:
            !(false)  Devuelve **true**
        
            !x      Devuelve **true** si x es false, si no, devuelve **false**


        ||  OR

            Devuelve true si alguno de los dos valores es **true**, solo devuelve **false** si los dos son falso

            Ejemplo:

            a || b  Devuelve **true** si a es **true** o si b es **true**

            false || false  Devuelve **false** 
            true || false   Devuelve **true**

            true || true    Devuelve **true**

        &&  AND

            Devuelve true solo si los dos valores son **true**

            Ejemplo:

            a && b  Devuelve **true** solo si a y b son **true**

            true && false   Devuelve **false**

        */

        //Determinamos si hay que ceder el lugar de un asiento si es mayor de edad o si es un niño

        //Esta variable sera true si la edad es menor que 15 o si es mayor que 40
        bool HayQueCederLugar = EsMayorDeEdad || EsUnNiño;
    }
}