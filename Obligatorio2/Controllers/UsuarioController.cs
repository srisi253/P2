using Microsoft.AspNetCore.Mvc;
using System;
using Obligatorio2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Obligatorio2.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "admin")
            {
                return View(s.GetClientes());
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("logueadoNombre") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("logueadoNombre") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");

            }
        }

        public IActionResult Registro()
        {
            if (HttpContext.Session.GetString("logueadoNombre") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Login(string nombreUsuario, string password)
        {
            Usuario u = s.Login(nombreUsuario, password);

            if (u != null)
            {
                HttpContext.Session.SetString("logueadoNombre", u.Nombre);
                HttpContext.Session.SetString("logueadoApellido", u.Apellido);
                HttpContext.Session.SetString("logueadoNombreUsuario", u.NombreUsuario);
                HttpContext.Session.SetString("logueadoRol", u.Rol);
                HttpContext.Session.SetInt32("logueadoId", u.Id);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Resultado = "Usuario y/o contraseña no válido";
                return View();
            }


        }

        [HttpPost]
        public IActionResult Registro(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string password)
        {
            Usuario u = s.AltaUsuario(nombre, apellido, email, fechaNacimiento, nombreUsuario, password);

            if (u != null)
            {
                ViewBag.Resultado = "Alta exitosa";
            }
            else
            {
                ViewBag.Resultado = "Error de alta";

            }

            return View();
        }

        [HttpPost]
        public IActionResult Logout(string n)
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}
