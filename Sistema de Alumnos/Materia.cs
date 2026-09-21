using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Materia : IExportable
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int CantidadHoras { get; set; }

        public Materia (string nombre, int codigo, int cantidadhoras)
        {
            Nombre = nombre;
            Codigo = codigo;
            CantidadHoras = cantidadhoras;
        }

        public string ExportarLinea()
        {         
            return $"MATERIA; {Codigo}; {Nombre}; {CantidadHoras}";
        }
}
}
