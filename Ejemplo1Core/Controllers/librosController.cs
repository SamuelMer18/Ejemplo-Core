using Microsoft.AspNetCore.Mvc;
using Ejemplo1Core.Data;
using Ejemplo1Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejemplo1Core.Controllers
{
    public class librosController : Controller
    {
        private readonly PracticaContext _context;
        public librosController(PracticaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<libro> ListaLibros = _context.libro;
            return View(ListaLibros);
        }
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(libro Libro)
        {
            if (ModelState.IsValid)
            {
                _context.libro.Add(Libro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Editar(int? Id)
        {
            if ( Id==null)
            {

                return NotFound();
            }
            //obtener datos
            var libro = _context.libro.Find(Id);
            if (libro==null)
            {
                return NotFound();
            }
            return View(libro);
        }
        [HttpPost]
        public IActionResult Edit(libro Libro)
        {
            if (ModelState.IsValid)
            {   
                _context.libro.Update(Libro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null)
            {

                return NotFound();
            }
            //obtener datos
            var libro = _context.libro.Find(Id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }
        [HttpPost]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var libro = _context.libro.Find(Id);
            _context.libro.Remove(libro);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
