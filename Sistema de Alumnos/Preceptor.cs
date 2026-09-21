using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Preceptor : Persona
    {
        public string Año { get; set; }

        public Preceptor (string nombre, int documento, string año) : base (nombre, documento)
        {
            Año = año;
        }
        public override string Presentarse()
        {
            return $"Hola, soy {Nombre} y soy preceptor de {Año}";
        }
    }
}
