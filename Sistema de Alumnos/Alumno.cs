using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Legajo { get; private set; }
        public decimal Nota1 { get; private set; }
        public decimal Nota2 { get; private set; }
        public Alumno(string nombre, int legajo)
        {
            Nombre = nombre;
            Legajo = legajo;
        }
        public decimal Promedio() 
        { 
            decimal notaPromedio = (Nota1 + Nota2) / 2; 
            return notaPromedio; 
        }

        public bool EstaAprobado() 
        {
            decimal notaPromedio = Promedio();
            if (notaPromedio >= 6) 
            {
                return true;
            }
            return false;
        }
        public void SubirNota() 
        {
            if (Nota1 <= 9)
            {
                Nota1 = Nota1 + 1;
            }
            if (Nota2 <= 9)
            {
                Nota2 = Nota2 + 1;
            }
        }
        public override string ToString()
        {
            return $"{Legajo} - {Nombre} (promedio: {Promedio()})";
        }
        public bool CargarNotas(decimal nota1, decimal nota2)
        {
            if ((nota1 >= 0 && nota1 <= 10) && (nota2 >= 0 && nota2 <= 10))
            {
                Nota1 = nota1;
                Nota2 = nota2;
                return true;
            }
            return false;
        }
    }
}
