using Microsoft.AspNetCore.Mvc;
using System;
using Obligatorio2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace Obligatorio2.Controllers
{
    public class ActividadController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View(s.GetActividades());
        }

        public IActionResult ComprarEntrada(int idActividad)
        {
            if (HttpContext.Session.GetString("logueadoNombre") != null)
            {
                Actividad actividadComprar = s.GetActividad(idActividad);
                ViewBag.ActividadComprar = actividadComprar;
                return View();
            }
            return RedirectToAction("Index", "Actividad");
        }

        [HttpPost]
        public IActionResult ComprarEntrada(int CantidadEntradas, int idActividad)
        {
            int? idusuario = HttpContext.Session.GetInt32("logueadoId");
            Usuario logueado = s.GetUsuario(idusuario);

            Actividad actividadComprar = s.GetActividad(idActividad);

            ViewBag.ActividadComprar = actividadComprar;

            if (actividadComprar.FechayHora > DateTime.Now)
            {
                Compra c = s.AltaCompra(logueado, CantidadEntradas, actividadComprar, DateTime.Now);
                if (c != null)
                {
                    ViewBag.Resultado = "Compra exitosa";
                }
                else
                {
                    ViewBag.Resultado = "La compra no se ha realizado";

                }
            }
            else
            {
                ViewBag.Resultado = "La compra no se ha realizado";

            }

            return View();
        }

        //Dar Me gusta a una actividada dada. Es necesario ser usuario del tipo cliente.
        public IActionResult MeGusta(int idActividad)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "cliente")
            {
                Actividad a = s.GetActividad(idActividad);
                a.MeGusta();
                return RedirectToAction("Index", "Actividad");
            }
            else
            {
                return RedirectToAction("Index", "Actividad");
            }

        }

        //public IActionResult IndexLugar(string lugar)
        //{
        //    return View(s.ActividadesEnLugar(lugar));
        //}

    }
}
