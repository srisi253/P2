using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2.Models
{
    public class Actividad
    {

        private static int ultimoIdA = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime FechayHora { get; set; }
        public Lugar Lugar { get; set; }
        public double PrecioBase { get; set; }
        public TipoEdad EdadMinima { get; set; }
        public int CantidadLikes { get; set; }


        public enum TipoEdad
        {
            P,
            C13,
            C16,
            C18
        }


        public Actividad(string nombre, Categoria categoria, DateTime fechayHora, Lugar lugar, double precioBase, TipoEdad edadMinima, int cantidadLikes)
        {
            Id = ultimoIdA;
            ultimoIdA++;
            Nombre = nombre;
            Categoria = categoria;
            FechayHora = fechayHora;
            Lugar = lugar;
            PrecioBase = precioBase;
            EdadMinima = edadMinima;
            CantidadLikes = cantidadLikes;
        }

        public double CalcularPrecioEntrada()
        {
            double precioFinal = Lugar.CalcularPrecio() * PrecioBase;
            precioFinal = Math.Round(precioFinal);
            return precioFinal;
        }

        public int MeGusta()
        {
            CantidadLikes++;
            return CantidadLikes;
        }



        public override string ToString()
        {
            return "Nombre:" + Nombre + " |Categoria: " + Categoria + " |Fecha:" + FechayHora + " |Lugar:" + Lugar +
                " |Edad Mínima:" + EdadMinima +  " |Cantidad de Likes: " + CantidadLikes;
        }


    }
}
