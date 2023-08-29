using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2.Models
{
    public class Abierto : Lugar
    {

        public Abierto(string nombre, int dimension)
        {
            Id = ultimoIdL;
            ultimoIdL++;
            Nombre = nombre;
            Dimension = dimension;
        }



        //Retorna el recargo que hay que realizarle al precio de una entrada
        public override double CalcularPrecio()
        {
            double recargo = 1;
            if (Dimension > 1)
            {
                recargo *= 1.1;
            }
            return recargo;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
