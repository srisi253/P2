using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Obligatorio2.Models
{
    public class Usuario : IComparable<Usuario>
    {
        private static int ultimoIdU = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string NombreUsuario { get; set; }

        public string Password { get; set; }

        public string Rol { get; set; }

        public Usuario(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string password)
        {
            Id = ultimoIdU;
            ultimoIdU ++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = "cliente";

        }
        public int CompareTo([AllowNull] Usuario other)
        {
            if (Apellido.CompareTo(other.Apellido) > 0)
            {
                return 1;

            }
            else if (Apellido.CompareTo(other.Apellido) < 0)
            {
                return -1;
            }
            else
            {
                if (Nombre.CompareTo(other.Nombre) > 0)
                {
                    return 1;

                }
                else if (Nombre.CompareTo(other.Nombre) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
