using Microsoft.AspNetCore.Mvc;
using System;
using Obligatorio2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Obligatorio2.Controllers
{
    public class CompraController : Controller
    {
        Sistema s = Sistema.GetInstancia();

        //Lista de todas las compras del sistema.
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "admin")
            {
                return View(s.GetCompras());
            }
            return RedirectToAction("Index", "Home");
        }

        //Lista de todas las compras realizadas por un usuario dado
        public IActionResult MisCompras()
        {
            int? idusuario = HttpContext.Session.GetInt32("logueadoId");
            if (HttpContext.Session.GetString("logueadoRol") == "cliente")
            {
                return View(s.GetComprasUsuario(idusuario));
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult CancelarCompra(int idCompra)
        {
            if (HttpContext.Session.GetString("logueadoNombre") != null)
            {
                Compra compraCancelar = s.GetCompra(idCompra);
                ViewBag.CompraCancelar = compraCancelar;
                if (DateTime.Now.AddHours(24) <= compraCancelar.Actividad.FechayHora)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult CancelarCompra(int idCompra, string estadoCompra)
        {
            if (HttpContext.Session.GetString("logueadoNombre") != null)
            {
                Compra compraCancelar = s.GetCompra(idCompra);
                compraCancelar.CancelarCompra();
                ViewBag.CompraCancelar = compraCancelar;
                return RedirectToAction("MisCompras", "Compra");
            } else
            {
                return RedirectToAction("Index", "Home");

            }

        }

        [HttpPost]

        public IActionResult Index(DateTime fechaInicial, DateTime fechaFinal)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "admin")
            {
                List<Compra> comprasEntreFechas = s.ComprasEntreFechas(fechaInicial, fechaFinal);
                if (comprasEntreFechas.Count() == 0)
                {
                    ViewBag.Mensaje = "No se han encontrado compras entre las fechas ingresadas";
                    return View(comprasEntreFechas);
                } else
                {
                    ViewBag.Mensaje = "aca va mensaje";
                    return View(comprasEntreFechas);

                }

            }
            else
            {
                return View(s.GetCompras());
            }

        }
    }
}
