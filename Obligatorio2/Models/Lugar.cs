using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2.Models
{
    public abstract class Lugar
    {
        protected static int ultimoIdL = 1;
        public int Id { set; get; }
        public string Nombre { set; get; }
        public int Dimension { set; get; }

        //Retorna el recargo que hay que realizarle al precio de una entrada
        public abstract double CalcularPrecio();
    }
}
