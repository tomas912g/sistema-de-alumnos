using Sistema_de_Alumnos;
using static System.Runtime.InteropServices.JavaScript.JSType;

Alumno alumno1 = new Alumno()
{
    Nombre = "Augusto",
    Legajo = 1,
    Nota1 = 10,
    Nota2 = 3,
};
Alumno alumno2 = new Alumno()
{
    Nombre = "Peira",
    Legajo = 2,
    Nota1 = 8,
    Nota2 = 7,
};

Console.WriteLine($"Alumno: {alumno1.Nombre}. Legajo: {alumno1.Legajo}");
Console.WriteLine($"Alumno: {alumno2.Nombre}. Legajo: {alumno2.Legajo}");
