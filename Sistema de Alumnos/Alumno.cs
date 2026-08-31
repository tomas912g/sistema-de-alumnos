using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Alumno
    {
        public required string Nombre { get; set; }
        public int Legajo { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
    }
}
