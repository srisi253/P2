using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2.Models
{
    public class Categoria
    {
        //PROPIEDADES
        private static int ultimoIdCa = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        //CONSTRUCTOR
        public Categoria(string nombre, string descripcion)
        {
            Id = ultimoIdCa;
            ultimoIdCa++;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        //ToStirng
        public override string ToString()
        {
            return Nombre;
        }

        public Categoria()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Categoria categoria &&
                   Nombre == categoria.Nombre;
        }
    }
}
