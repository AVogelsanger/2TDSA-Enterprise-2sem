using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{

    public class CategoriaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

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
            return View();
        }
    }
}