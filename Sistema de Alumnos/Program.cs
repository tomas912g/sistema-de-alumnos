using Sistema_de_Alumnos;
using static System.Runtime.InteropServices.JavaScript.JSType;

Alumno alumno1 = new Alumno("Augusto", 1, 10m, 3m);

Alumno alumno2 = new Alumno("Peira", 2, 8m, 7m);

//Al hacer un new Alumno() vacio, sale este error porque al definir yo mismo un metodo constructoor el prgrama verifica que cumpla exacetamente con los parametros que tiene que tener (como yo lo defini en el constructor)

Console.WriteLine($"Alumno: {alumno1.Nombre}. Legajo: {alumno1.Legajo}");
Console.WriteLine($"Alumno: {alumno2.Nombre}. Legajo: {alumno2.Legajo}");
