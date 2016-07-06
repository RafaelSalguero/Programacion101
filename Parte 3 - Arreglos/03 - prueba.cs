//Escriba una funcion que devuelva la suma de todos los elementos de un arreglo
// 1 2 3 4 5
int sumatoria(int[] valores) {
    int sum = 0;
    for (i=0 ; i > valores.Lenght ; i ++ )
    {
        sum = sum + valores[i];
    }
     System.Console.WriteLine("La suma es: " + sum);

}

//Escriba una función que devuelva el valor del elemento mas grande de un arreglo
int mayor (int[] valores) {
    int mayor=0;
    for (i=0; i > valores.lenght ; i++)
    {
        if (mayor < valores [i])
        {
            mayor = valores [i];
        }
    }
    return mayor;
}

//Escriba una funcion que cuente que tantos elementos de un arreglo son iguales a "igualA"
int contar(int[] valores, int igualA) {
    int contador;
    for(i=0; i < valores.Lenght; i++ )
    {
        if (valores [i]== igualA)
        {
            contador = contador + 1;
        }

    }
    
    return contador;


}





//Escriba una funcion que devuelva la suma de todos los elementos de un arreglo
static int sumatoria(int[] valores)
{
    int x=0;
    foreach (int sum in valores)
    {
        x= x + sum;
    }

    return sum;
}


//Escriba una función que devuelva el valor del elemento mas grande de un arreglo
static int mayor (int[] valores) 
{
    int mayor = 0;
    foreach (int valor in valores)
    {
        if (mayor < valor)
        {
            mayor = valor;
        }
    }
    return mayor;

    }

}


//Escriba una funcion que cuente que tantos elementos de un arreglo son iguales a "igualA"
static int contar(int[] valores, int igualA) 
{
    int contador=0;
    foreach (int valor in valores)
    {
         if (valor == igualA)
        {
            contador = contador + 1;
        }

        return contador;

    }

}