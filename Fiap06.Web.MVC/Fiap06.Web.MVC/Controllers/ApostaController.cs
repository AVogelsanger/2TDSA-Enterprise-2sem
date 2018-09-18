using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class ApostaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        public ActionResult Cadastrar()
        {
            var lista = _unit.ConcursoRepository.Listar();
            ViewBag.concursos = new SelectList(lista, "Numero", "Numero"); 
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar(Aposta aposta)
        {
            return View();
        }
    }
}