//Prueba


/**
Escriba una funcion que devuelva el area de un triangulo si tipo == "triangulo", pero
que devuelva el area de un rectangulo si tipo == "rectangulo"}

Si tipo no es ni "rectangulo" ni "triangulo", debe de devolver -1 
**/
static int area(string tipo, int b, int a) 
{

    if (tipo = "triangulo")
        {
            area = (b * a)/2;
        }
    else if (tipo = "rectagulo")
        {
            area = b * a;
        }
        else
        {
            area = -1;
        }

    return area;
}