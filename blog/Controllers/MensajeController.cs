
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TuProyecto.Models;

namespace blog.Controllers
{
    public class MensajeController : Controller
    {
        private static List<Mensaje> mensajes = new List<Mensaje>();

        // GET: Mensaje
        public ActionResult Index()
        {
            return View(mensajes);
        }

        // GET: Mensaje/Crear
        public ActionResult Crear()
        {
            return View();
        }

        // POST: Mensaje/Crear
        [HttpPost]
        public ActionResult Crear(Mensaje mensaje)
        {
            mensaje.FechaPublicacion = DateTime.Now;
            mensajes.Add(mensaje);
            return RedirectToAction("Index");
        }
    }
}

