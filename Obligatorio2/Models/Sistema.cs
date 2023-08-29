using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2.Models
{
    public class Sistema
    {

        private static Sistema instancia = null;

        //CONSTRUCTOR
        private Sistema()
        {
            PrecargaDatos();
        }


        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }


        //VALORES ÚNICOS PREDEFINIDOS
        private static int AforoMax = 50;
        private static double PrecioButaca = 300;

        //LISTAS
        private List<Lugar> lugares = new List<Lugar>();
        private List<Actividad> actividades = new List<Actividad>();
        private List<Usuario> usuarios = new List<Usuario>();



        private List<Compra> compras = new List<Compra>();
        private List<Categoria> categorias = new List<Categoria>();


        // GETS DE LISTAS
        public List<Lugar> GetLugares() { return lugares; }
        public List<Actividad> GetActividades() { return actividades; }
        public List<Usuario> GetUsuarios() {
            usuarios.Sort();
            return usuarios;
        }
        public List<Compra> GetCompras() { return compras; }
        public List<Categoria> GetCategorias() { return categorias; }


        //Retorna la lista de compras de un usuario determinado
        public List<Compra> GetComprasUsuario(int? idUsuario)
        {
            List<Compra> comprasUsuario = new List<Compra>();
            foreach (Compra c in compras)
            {
                if (c.Usuario.Id.Equals(idUsuario))
                {
                    comprasUsuario.Add(c);
                }
            }
            return comprasUsuario;
        }

        // Lista de usuarios "cliente"
        public List<Usuario> GetClientes()
        {
            List<Usuario> clientes = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (u.Rol == "cliente")
                {
                    clientes.Add(u);
                }
            }
            clientes.Sort();
            return clientes;
        }


        //CAMBIAR EL AFORO MAXIMO
        public bool CambiarAforoMax(int nuevoAforoMax)
        {
            bool ret = false;
            if(nuevoAforoMax >= 0 && nuevoAforoMax <= 100)
            {
                AforoMax = nuevoAforoMax;
                ret = true;
            }
            return ret;

        }

        //CAMBIAR EL PRECIO DE LA BUTACA EN ESPACIO ABIERTO
        public bool CambiarPrecioButaca(double nuevoPrecio)
        {
            bool ret = false;
            if (nuevoPrecio >= 0)
            {
                PrecioButaca = nuevoPrecio;
                ret = true;
            }
            return ret;
        }

        //CONSULTAR AFORO MAXIMO
        public static int GetAforoMax()
        {
            return AforoMax;
        }

        //CONSULTAR VALOR DEL PRECIO BUTACA
        public static double GetPrecioButaca()
        {
            return PrecioButaca;
        }

        //METODOS DE SESION

        public Usuario Login(string nombreUsuario, string password)
        {
            bool encontrado = false;
            Usuario buscado = null;

            foreach (Usuario u in usuarios) if (!encontrado)
                {
                    if (u.NombreUsuario.Equals(nombreUsuario) && u.Password.Equals(password))
                    {
                        encontrado = true;
                        buscado = u;
                    }

                }
            return buscado;
        }


        //VALIDAR EMAIL: DEBE CONTENER "@" Y DEBE SER UNICO;
        private bool EmailValido(string email)
        {
            bool valido = false;
            bool tieneArroba = false;
            if (email != "")
            {
                foreach (char letra in email)
                {

                    if (letra.ToString().Equals("@"))
                    {
                        tieneArroba = true;
                    }
                }
                if (tieneArroba)
                {
                    bool encontrado = false;
                    foreach (Usuario u in usuarios) if (!encontrado)
                        {
                            if (u.Email.Equals(email))
                            {
                                encontrado = true;
                            }
                        }

                    if (!encontrado)
                    {
                        valido = true;
                    }
                }
            }
            return valido;
        }

        //Validacion nombreUsuario
        private bool NombreUsuarioValido(string nombreUsuario)
        {
            bool valido = false;
            bool encontrado = false;
            foreach (Usuario u in usuarios) if (!encontrado)
            {
                    if (u.NombreUsuario.Equals(nombreUsuario))
                    {
                        encontrado = true;
                    }
            }
            if (!encontrado)
            {
                valido = true;
            }
            return valido;
        }


        //Validacion de Password
        private bool PasswordValido(string password)
        {
            bool ret = false;
            int mayusc = 0;
            int minusc = 0;
            int digito = 0;
            string digitos = "0123456789";

            for (int i = 0; i < password.Length; i++)
            {
                if (digitos.Contains(password[i]))
                {
                    digito++;
                }
                else if (password[i] == password.ToUpper()[i])
                {
                    mayusc++;
                }
                else if(password[i] == password.ToLower()[i])
                {
                    minusc++;
                }
            }

            if (mayusc > 0 && minusc > 0 && digito > 0 && password.Length > 5)
            {
                ret = true;
            }

            return ret;
        }

        //DADO UN ID DE ACTIVIDAD, RETORNAR EL OBJETO ACTIVIDAD

        public Actividad GetActividad(int idActividad)
        {
            Actividad ret = null;

            foreach (Actividad a in actividades)
            {
                if (a.Id.Equals(idActividad))
                {
                    ret = a;
                }
            }

            return ret;
        }

        //DADO UN ID DE compra, RETORNAR EL OBJETO compra

        public Compra GetCompra(int idCompra)
        {
            Compra ret = null;

            foreach (Compra c in compras)
            {
                if (c.Id.Equals(idCompra))
                {
                    ret = c;
                }
            }

            return ret;
        }

        //DADO UN ID DE usuario, RETORNAR EL OBJETO USUARIO

        public Usuario GetUsuario(int? idUsuario)
        {
            Usuario ret = null;

            foreach (Usuario u in usuarios)
            {
                if (u.Id.Equals(idUsuario))
                {
                    ret = u;
                }
            }

            return ret;
        }

        // LISTA DE ACTIVIDADES EN UN LUGAR DADO

        public List<Actividad> ActividadesEnLugar(string lugar)
        {
            List<Actividad> actividadesEnLugar = new List<Actividad>();

            foreach (Actividad a in actividades)
            {
                if (a.Lugar.Nombre == lugar)
                {
                    actividadesEnLugar.Add(a);
                }
            }
            return actividadesEnLugar;
        }



        //LISTA DE TODAS LAS COMPRAS DEL SISTEMA ENTRE DOS FECHAS
        public List<Compra> ComprasEntreFechas(DateTime f1, DateTime f2)
        {
            List<Compra> ComprasEntreFechas = new List<Compra>();

            foreach (Compra c in compras)
            {
                if (c.FechayHora > f1 && c.FechayHora < f2)
                {
                    ComprasEntreFechas.Add(c);
                }
            }
            return ComprasEntreFechas;
        }

        //DADA UNA CATEGORIA Y DOS FECHAS, RETORNA LA LISTA DE ACTIVIADES DE LA CATEGORIA ENTRE LAS FECHAS DADAS
        public List<Actividad> ActividadesEntreFechasConCategoria (DateTime f1, DateTime f2, string categoria)
        {
            List<Actividad> actividadesFiltradasPorCategoria = new List<Actividad>();
            foreach (Actividad act in GetActividades())
            {
                Categoria cat = new Categoria();
                cat.Nombre = categoria;
                if (act.Categoria.Equals(cat))
                {
                    actividadesFiltradasPorCategoria.Add(act);
                }
            }

            List<Actividad> actividadesEntreFechas = new List<Actividad>();

            foreach (Actividad act in actividadesFiltradasPorCategoria)
            {
                if (act.FechayHora > f1 && act.FechayHora < f2)
                {
                    actividadesEntreFechas.Add(act);
                }
            }
            return actividadesEntreFechas;
        }

        //RETORNA LAS COMPRAS DE MAYOR VALOR

        public List<Compra> ComprasMayorValor()
        {
            List<Compra> comprasMayorValor = new List<Compra>();
            double mayorMonto = 0;

            foreach (Compra c in compras)
            {
                if (c.PrecioFinal() > mayorMonto)
                {
                    comprasMayorValor.Clear();
                    comprasMayorValor.Add(c);
                    mayorMonto = c.PrecioFinal();
                }
                else if (c.PrecioFinal() == mayorMonto)
                {
                    comprasMayorValor.Add(c);
                }
            }

            return comprasMayorValor;

        }



        //ALTAS DE DATOS
        public Abierto AltaLugarAbierto(string nombre, int dimension)
        {
            Abierto nuevo = null;
            if (nombre != "" && dimension >= 0)
            {

                nuevo = new Abierto(nombre, dimension);
                lugares.Add(nuevo);

            }
            return nuevo;
        }

        public Cerrado AltaLugarCerrado(string nombre, int dimension, bool accesibilidad, double valorMantenimiento)
        {
            Cerrado nuevo = null;
            if (nombre != "" && dimension >= 0 && valorMantenimiento >= 0)
            {

                nuevo = new Cerrado(nombre, dimension, accesibilidad, valorMantenimiento);
                lugares.Add(nuevo);

            }
            return nuevo;
        }

        public Usuario AltaUsuario(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string password)
        {
            Usuario nuevo = null;
            if (nombre.Length > 1 && apellido.Length > 1 && EmailValido(email) && fechaNacimiento > DateTime.Parse("1-1-0001") && fechaNacimiento < DateTime.Now
                && nombreUsuario != "" && PasswordValido(password) && NombreUsuarioValido(nombreUsuario))
            {
                nuevo = new Usuario(nombre, apellido, email, fechaNacimiento, nombreUsuario, password);
                usuarios.Add(nuevo);
            }
            return nuevo;
        }


        public Actividad AltaActividad(string nombre, Categoria categoria, DateTime fechayHora, Lugar lugar, double precioBase, Actividad.TipoEdad edadMinima, int cantidadLikes)
        {
            Actividad nueva = null;
            if (nombre != "" &&  precioBase >= 0 && cantidadLikes >= 0)
            {
                nueva = new Actividad(nombre, categoria, fechayHora, lugar, precioBase, edadMinima, cantidadLikes);
                actividades.Add(nueva);

            }
            return nueva;
        }

        public Compra AltaCompra(Usuario usuario, int cantidadEntradas, Actividad actividad, DateTime fecha)
        {
            Compra nueva = null;
            if (cantidadEntradas >= 1)
            {
                nueva = new Compra(usuario, cantidadEntradas, actividad, fecha);
                compras.Add(nueva);
            }
            return nueva;
        }

        public Categoria AltaCategoria(string nombre, string descripcion)
        {
            Categoria nueva = null;
            if (nombre != "")
            {
                nueva = new Categoria(nombre, descripcion);
                categorias.Add(nueva);
            }
            return nueva;
        }


        //PRECARGA DE DATOS
        private void PrecargaDatos()
        {
            Abierto la1 = AltaLugarAbierto("Estadio Centenario", 7140);
            Abierto la2 = AltaLugarAbierto("Teatro de verano ", 750);
            Abierto la3 = AltaLugarAbierto("Plaza de los artesanos", 100);

            Cerrado lc1 = AltaLugarCerrado("Teatro Sodre", 2000, true, 1000);
            Cerrado lc2 = AltaLugarCerrado("Antel Arena", 1500, true, 1500);
            Cerrado lc3 = AltaLugarCerrado("Cine Movie Portones", 200, false, 1200);

            Categoria c1 = AltaCategoria("Cine", "El cine es ideal para relajarse mientras se observan las mejores peliculas del momento");
            Categoria c2 = AltaCategoria("Teatro", "El teatro es un ambiente ideal para disfrutar el dia en familia");
            Categoria c3 = AltaCategoria("Concierto", "Nada mas lindo que disfrutar con amigos de buena musica");
            Categoria c4 = AltaCategoria("Feria gastronomica", "Ideal para un paseo, donde se podran experimentar distintas sensaciones en el paladar");
            Categoria c5 = AltaCategoria("Deportivo", "Para los amantes del deporte");

            Actividad ac1 = AltaActividad("Cuarteto de Nos", c3, DateTime.Parse("2022-10-20"), la1, 500, Actividad.TipoEdad.C13, 10);
            Actividad ac2 = AltaActividad("Feria Navideña", c4, DateTime.Parse("2021-12-15"), la3, 150, Actividad.TipoEdad.P, 100);
            Actividad ac3 = AltaActividad("Eliminatorias Mundial Rugby", c5, DateTime.Parse("2021-10-09 16:00"), la1, 250, Actividad.TipoEdad.P, 200);
            Actividad ac4 = AltaActividad("Carnaval", c3, DateTime.Parse("2022-02-01 20:00"), la2, 200, Actividad.TipoEdad.C16, 150);
            Actividad ac5 = AltaActividad("Feria DeGusto", c4, DateTime.Parse("2021-11-05 11:00"), la3, 0, Actividad.TipoEdad.P, 80);

            Actividad ac6 = AltaActividad("Ballet El mago de Oz", c2, DateTime.Parse("2021-10-25 21:00"), lc1, 500, Actividad.TipoEdad.C18, 10);
            Actividad ac7 = AltaActividad("Final Metro", c5, DateTime.Parse("2021-10-30 20:30"), lc2, 300, Actividad.TipoEdad.P, 200);
            Actividad ac8 = AltaActividad("Harry Potter", c1, DateTime.Parse("2021-11-10 19:00"), lc3, 250, Actividad.TipoEdad.C16, 20);
            Actividad ac9 = AltaActividad("Cirque du Soleil", c2, DateTime.Parse("2021-12-03 20:00"), lc2, 800, Actividad.TipoEdad.C13, 100);
            Actividad ac10 = AltaActividad("Filarmonica", c2, DateTime.Parse("2021-12-15 21:00"), lc1, 600, Actividad.TipoEdad.C13, 30);

            Usuario u1 = AltaUsuario("Fulanita", "De Tal", "fulanita@mail", DateTime.Parse("3-6-1995"), "fdetal", "FdeTal1234");
            Usuario u2 = AltaUsuario("Menganito", "XX", "menganito@mail", DateTime.Parse("10-16-1998"), "mxx", "Mx1234");
            Usuario u3 = AltaUsuario("Sultanito", "Perez", "sultanito@mail", DateTime.Parse("3-15-1991"), "sperez", "Sp1234");
            Usuario u4 = AltaUsuario("Juan", "Gomez", "juan@mail", DateTime.Parse("10-25-1987"), "jgomez", "Jg1234");
            Usuario u5 = AltaUsuario("Sofia", "Gomez", "sofia@mail", DateTime.Parse("3-15-1998"), "sgomez", "Sg1234");
            Usuario u6 = AltaUsuario("Ana", "Perez", "ana@mail", DateTime.Parse("6-10-1965"), "aperez", "Ap1234");
            u3.Rol = "admin";
            u1.Rol = "admin";

            Compra co1 = AltaCompra(u2, 10, ac2, DateTime.Parse("6-6-2021"));
            Compra co2 = AltaCompra(u2, 5, ac6, DateTime.Parse("7-5-2021"));
            Compra co3 = AltaCompra(u4, 8, ac10, DateTime.Parse("3-3-2021"));
            Compra co4 = AltaCompra(u4, 6, ac8, DateTime.Parse("9-19-2021"));
            Compra co5 = AltaCompra(u5, 10, ac9, DateTime.Parse("2-22-2021"));
            Compra co6 = AltaCompra(u5, 3, ac3, DateTime.Parse("5-28-2021"));
            Compra co7 = AltaCompra(u6, 10, ac9, DateTime.Parse("1-21-2021"));
            Compra co8 = AltaCompra(u6, 6, ac2, DateTime.Parse("8-12-2021"));
            Compra co9 = AltaCompra(u2, 4, ac5, DateTime.Parse("9-9-2021"));
            Compra co10 = AltaCompra(u6, 8, ac9, DateTime.Parse("7-11-2021"));
            Compra co11 = AltaCompra(u4, 7, ac1, DateTime.Parse("3-6-2021"));

        }



    }
}
