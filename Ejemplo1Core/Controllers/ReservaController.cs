using Ejemplo1Core.Data;
using Ejemplo1Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ejemplo1Core.Controllers
{
    public class ReservaController : Controller
    {
        private readonly PracticaContext _context;
        public ReservaController(PracticaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Reserva> lista = _context.Reserva;
            return View(lista);
        }

        public IActionResult Crear()
        {
            ViewData["EstudianteId"]= new SelectList(_context.Estudiante, "Id", "Nombre");
            ViewData["LibroId"] = new SelectList(_context.libro, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Reserva.Add(reserva);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
