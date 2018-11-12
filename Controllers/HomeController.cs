using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabajo.Models;

namespace Trabajo.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrabajoContext _context;
        public HomeController(TrabajoContext context)
        {
            this._context = context;

        }
        public IActionResult Index()
        {
            var lista = _context.Eventos.Include(x => x.Nombre).Include(x=>x.Descripcion)
                                       .OrderByDescending(b => b.Id)
                                       .ToList();

            return View(lista);
        }
        public IActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agregar(Evento e)
        {
            if(ModelState.IsValid)
            {
                _context.Add(e);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(e);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [HttpPost]
         public IActionResult Contact(Alumno a)
        {
            if(ModelState.IsValid)
            {
                _context.Add(a);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(a);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
