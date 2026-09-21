using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Profesor : Persona
    {
        public string Dicta {  get; set; }

        public Profesor (string nombre, int documento, string dicta) : base(nombre, documento)
        {
            Dicta = dicta;
        }
    }
}
