using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Documento { get; set; }

        public Persona(string nombre, int documento)
        {
            Nombre = nombre;
            Documento = documento;
        }
    }
}
