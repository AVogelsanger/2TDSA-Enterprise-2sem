using Fiap.NAC.Correcao.Models;
using Fiap.NAC.Correcao.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.NAC.Correcao.Controllers
{
    public class CategoriaController : Controller
    {

        public UnitOfWork _unit = new UnitOfWork();

        // GET: Categoria
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Categoria categoria)
        {
            _unit.CategoriaRepository.Cadastrar(categoria);
            _unit.Salvar();
            TempData["msg"] = "Categoria cadastrada!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}