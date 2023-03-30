using Ejemplo1Core.Data;
using Ejemplo1Core.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
