//Escriba una funcion que devuelva la suma de todos los elementos de un arreglo
int sumatoria(int[] valores) {
    int sum;
    for (i=0 ; i > valores.Lenght ; i ++ )
    {
        sum = valores[i];
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

}

//Escriba una funcion que cuente que tantos elementos de un arreglo son iguales a "igualA"
int contar(int[] valores, int igualA) {

    int contador;
    for (i=0; i > valores.lenght ; i++)
    {
        if (valores[i] == "igualA")
        {
            contador = contador + 1;
        }
        
    }

    console.writeline ("el numero de repeticiones de igualA es: "+contador)
    


}