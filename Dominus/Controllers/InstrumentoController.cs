using Dominus.Data;
using Dominus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dominus.Controllers
{
    public class InstrumentoController : Controller
    {
        readonly private ApplicationDbContext _db;

        public InstrumentoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<InstrumentoModel> instrumento = _db.Instrumento;
            return View(instrumento);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar (InstrumentoModel instrumento)
        {
            if (ModelState.IsValid)
            {
                _db.Instrumento.Add(instrumento);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Editar (int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            InstrumentoModel instrumento = _db.Instrumento.FirstOrDefault(x => x.Id == id); 

            if (instrumento == null)
            {
                return NotFound();
            }

            return View(instrumento);
        }

        [HttpPost]
        public IActionResult Editar (InstrumentoModel instrumento)
        {
            if (ModelState.IsValid)
            {
                _db.Instrumento.Update(instrumento);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(instrumento);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            InstrumentoModel instrumento = _db.Instrumento.FirstOrDefault(x => x.Id == id);

            if (instrumento == null)
            {
                return NotFound();
            }

            return View(instrumento);
        }

        [HttpPost]
        public IActionResult Excluir(InstrumentoModel instrumento)
        {
            if (instrumento == null)
            {
                return NotFound();
            }

            _db.Instrumento.Remove(instrumento);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
