/*
Note que la relación entre alumnos y materias es de muchos a muchos (un alumno se puede inscribir a muchas materias, y una materia puede tener muchos alumnos)
*/

class Materia {
    string Nombre;
}

class Alumno {
    string Nombre;
}

class Calificacion {
    Alumno Alumno;
    Materia Materia;

    //Valor de la calificacion
    decimal Valor;
}


/**Escriba un metodo para obtener el promedio de toda la escuela */
decimal PromedioGeneral(Calificacion[] calificaciones) {

}

/*Escriba un metodo que sirve para obtener el promedio de calificaciones por materia.

Recuerde que podemos saber si dos variables apuntan al mismo objeto utilizando el operador ==

@param calificaciones Un arreglo con todas las calificaciones de todos los alumnos y materias
@param materia La materia de la cual nos interesa saber su promedio
*/
decimal PromedioPorMateria(Calificacion[] calificaciones, Materia materia) {

}

/*
Escriba un metodo para obtener el promedio de calificaciones de un alumno
@param calificaciones Un arreglo con todas las calificaciones de todos los alumnos y materias
@param materia El alumno del cual nos interesa saber su promedio
*/
decimal PromedioPorAlumno(Calificacion[] calificaciones, Alumno alumno) {

}
