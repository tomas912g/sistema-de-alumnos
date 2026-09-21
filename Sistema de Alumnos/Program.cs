using Sistema_de_Alumnos;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Alumno> alumnos = new List<Alumno>();
bool salir = false;

while (salir == false)
{
    Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar por legajo");
    Console.WriteLine("4. Promedio del Curso");
    Console.WriteLine("5. Alumnos aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elija una opción: ");

    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        Console.WriteLine("Ingrese el nombre del alumno: ");
        string nombreAlumno = Console.ReadLine();

        Console.WriteLine("Ingrese el documento del alumno: ");
        int documentoAlumno = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el legado del alumno: ");
        int legajoAlumno = Convert.ToInt32(Console.ReadLine());

        Alumno alumnoNuevo = new Alumno(nombreAlumno,documentoAlumno, legajoAlumno);
        alumnos.Add(alumnoNuevo);
    }
    else if (opcion == "2")
    {
        foreach (Alumno alumnoListados in alumnos)
        {
            Console.WriteLine(alumnoListados);
        };
    }
    else if (opcion == "3")
    {
        Console.WriteLine("Ingrese el legajo a buscar:");
        int legajoBuscado = Convert.ToInt32(Console.ReadLine());

        bool encontrado = false;

        foreach (Alumno alumnoEnLista in alumnos)
        {
            if (alumnoEnLista.Legajo == legajoBuscado)
            {
                Console.WriteLine(alumnoEnLista);
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("Error: No existe alumno con ese legajo");
        }
    }
    else if (opcion == "4")
    {
        if (alumnos.Count == 0)
        {
            Console.WriteLine("Error: El promedio no se puede calcular");
        }
        else
        {
            decimal sumaTotal = 0;
            foreach (Alumno alumnoEnLista in alumnos)
            {
                sumaTotal = sumaTotal + alumnoEnLista.Promedio();
            }

            decimal promedioGeneral = sumaTotal / alumnos.Count;
            Console.WriteLine($"El promedio general del curso es: {promedioGeneral}");
        }
    }
    else if (opcion == "5")
    {
        int cantidadAprobados = 0;
        foreach (Alumno alumnoEnLista in alumnos)
        {
            if (alumnoEnLista.EstaAprobado() == true)
            {
                cantidadAprobados = cantidadAprobados + 1;
            }
        }
        Console.WriteLine($"Hay {cantidadAprobados} alumnos aprobados en el currso");
    }
    else if (opcion == "6")
    {
        salir = true;
    }
    
    else
    {
        Console.WriteLine("Opción inexistente, intente de nuevo.");
    }
}