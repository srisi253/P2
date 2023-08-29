using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2.Models
{
    public class Compra
    {
        private static int ultimoIdC = 1;

        public int Id { get; set; }
        public Usuario Usuario{ get; set; }
        public int CantidadEntradas { get; set; }
        public Actividad Actividad { get; set; }
        public DateTime FechayHora { get; set; }
        public string EstadoCompra { get; set; }

        public Compra(Usuario usuario, int cantidadEntradas, Actividad actividad, DateTime fecha)
        {
            Id = ultimoIdC;
            ultimoIdC++;
            Usuario = usuario;
            CantidadEntradas = cantidadEntradas;
            Actividad = actividad;
            FechayHora = fecha;
            EstadoCompra = "Activa";
        }

        public double PrecioFinal()
        {
            double precioFinal = Actividad.CalcularPrecioEntrada() * CantidadEntradas;
            return precioFinal;
        }

        //public Compra ComprarEntrada()
        //{
        //    return null;
        //}

        public string CancelarCompra()
        {
            if (DateTime.Now.AddHours(24)  <= Actividad.FechayHora && EstadoCompra == "Activa")
            {
                EstadoCompra = "Cancelada";
            }
            return EstadoCompra;
        }

        public override string ToString()
        {
            return "Id: " + Id;
        }
    }
}
