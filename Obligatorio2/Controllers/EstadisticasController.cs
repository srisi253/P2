using Microsoft.AspNetCore.Mvc;
using System;
using Obligatorio2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Obligatorio2.Controllers
{
    public class EstadisticasController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "admin")
            {
                return View(s.GetActividades());
            }
            return RedirectToAction("Index", "Home");
        }


        //Lista de Actividades realizadas en un lugar determinado.
        [HttpPost]

        public IActionResult IndexLugar(string lugar)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "admin")
            {
                List<Actividad> actividadesLugar = s.ActividadesEnLugar(lugar);
                if (actividadesLugar.Count() == 0)
                {
                    ViewBag.Mensaje = "No se han encontrado actividades a realizarse en " + lugar;
                    return View(actividadesLugar);
                }
                else
                {
                    ViewBag.Mensaje = "";
                    return View(actividadesLugar);
                }

            }
            else
            {
                return View(s.GetActividades());
            }

        }

        //Lista de actividades de determinadad categoria entre dos fechas dadas.

        [HttpPost]

        public IActionResult IndexFechasCategoria(DateTime fechaInicial, DateTime fechaFinal, string categoria)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "admin")
            {
                List<Actividad> actividadesCategoriaEntreFechas = s.ActividadesEntreFechasConCategoria(fechaInicial, fechaFinal, categoria);
                if (actividadesCategoriaEntreFechas.Count() == 0)
                {
                    ViewBag.Mensaje = "No se han encontrado actividades de la categoría " + categoria + " para las fechas seleccionadas";
                    return View(actividadesCategoriaEntreFechas);

                }
                else
                {
                    ViewBag.Mensaje = "";
                    return View(actividadesCategoriaEntreFechas);
                }

            }
            else
            {
                ViewBag.Mensaje = "";
                return View(s.GetActividades());
            }

        }
    }
}
