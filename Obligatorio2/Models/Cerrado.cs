using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2.Models
{
    public class Cerrado : Lugar
    {
        public bool Accesibilidad { get; set; }
        public double ValorMantenimiento { get; set; }

        public Cerrado(string nombre, int dimension, bool accesibilidad, double valorMantenimiento)
        {
            Id = ultimoIdL;
            ultimoIdL++;
            Nombre = nombre;
            Dimension = dimension;
            Accesibilidad = accesibilidad;
            ValorMantenimiento = valorMantenimiento;
        }

        //Retorna el recargo que hay que realizarle al precio de una entrada
        public override double CalcularPrecio()
        {
            double recargo = 1;
            if (Sistema.GetAforoMax() < 50)
            {
                recargo *= 1.3;
            }
            else if (Sistema.GetAforoMax() >= 50 && Sistema.GetAforoMax() <= 70)
            {
                recargo *= 1.15;
            }
            return recargo;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
