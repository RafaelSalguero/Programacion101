/*
Note que la relación entre alumnos y materias es de muchos a muchos (un alumno se puede inscribir a muchas materias, y una materia puede tener muchos alumnos)
*/

class Materia {
    public Materia(string Nombre) {
        this.Nombre = Nombre;
    }

    public string Nombre;
}

class Alumno {
    public Alumno(string Nombre) {
        this.Nombre = Nombre;
    }

    public string Nombre;
}

class Calificacion {
    public Calificacion(Alumno Alumno, Materia Materia, decimal Valor) {
        this.Alumno = Alumno;
        this.Materia = Materia;
        this.Valor = Valor;
    }

    public Alumno Alumno;
    public Materia Materia;

    //Valor de la calificacion
    public decimal Valor;
}


/**Escriba un metodo para obtener el promedio de toda la escuela */
decimal PromedioGeneral(Calificacion[] calificaciones) 
{
   decimal sum;
   foreach (Calificacion c in calificaciones)
   {
       sum = sum + c.Valor;
   }
   return sum / calificaciones.Length;
}

/*Escriba un metodo que sirve para obtener el promedio de calificaciones por materia.

Recuerde que podemos saber si dos variables apuntan al mismo objeto utilizando el operador ==

@param calificaciones Un arreglo con todas las calificaciones de todos los alumnos y materias
@param materia La materia de la cual nos interesa saber su promedio
*/
decimal PromedioPorMateria(Calificacion[] calificaciones, Materia materia)
{
    int a;
    float sum
    foreach (calificacion c in calificaciones)
    {
        if (c.materia == materia)
        {
        a = a + 1;
        sum= sum + c.valor;
        }
    }
    return sum / a;
}

/*
Escriba un metodo para obtener el promedio de calificaciones de un alumno
@param calificaciones Un arreglo con todas las calificaciones de todos los alumnos y materias
@param alumno El alumno del cual nos interesa saber su promedio
*/
decimal PromedioPorAlumno(Calificacion[] calificaciones, Alumno alumno)
{
    /*sumacalificaciones / numerodecalificaciones*/
    
    int cont;
    foreach (calificacion a in calificaciones)
    {
        suma = suma + a.valor;
        cont = cont + a.materia.lenght:
        return suma/cont;
        
    }   
}    

/*
Escriba un metodo para obtener el promedio de calificaciones de un alumno para cierta materia
@param calificaciones Un arreglo con todas las calificaciones de todos los alumnos y materias
@param alumno El alumno del cual nos interesa saber su promedio
@param materia La materia de la cual nos interesa saber el promedio
*/
decimal PromedioPorAlumnoMateria(Calificacion[] calificaciones, Alumno alumno, Materia materia) {

}

//Como saber si tu codigo funciona:
//Puedes probarlo con los siguientes datos:

//Primero creamos los objetos:
Alumno jose = new Alumno("jose");
Alumno alan = new Alumno("alan");

Materia matematicas = new Materia("matematicas");
Materia español = new Materia("español");

//Luego, creamos el arreglo de calificaciones:

Calificaciones[] calificaciones = new Calificaciones[] {
    //jose tiene 9 de promedio en matematicas
    new Calificacion(jose, matematicas, 10),
    new Calificacion(jose, matematicas, 9),
    new Calificacion(jose, matematicas, 8),    

    //jose tiene 6.66 de promedio en español
    new Calificacion(jose, español, 7),
    new Calificacion(jose, español, 5),
    new Calificacion(jose, español, 8),

    //alan tiene 8.33 de promedio en matematicas
    new Calificacion(alan, matematicas, 7),
    new Calificacion(alan, matematicas, 8),
    new Calificacion(alan, matematicas, 10),    

    //alan tiene 9.33 de promedio en español
    new Calificacion(alan, español, 9),
    new Calificacion(alan, español, 9),
    new Calificacion(alan, español, 10)

    //jose en general tiene 7.83 de promedio
    //alan en general tiene 8,83 de promedio
    //La escuela tiene un promedio de 8.33 
};

//Con los datos, podemos probar los metodos, en los comentarios
//dice que tanto debe de dar