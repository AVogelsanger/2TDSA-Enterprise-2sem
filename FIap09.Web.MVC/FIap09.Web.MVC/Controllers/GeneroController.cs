using FIap09.Web.MVC.Models;
using FIap09.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIap09.Web.MVC.Controllers
{
    public class GeneroController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        public ActionResult Lista()
        {
            return View(_unit.GeneroRepository.Listar());
        }

        public ActionResult Cadastrar(Genero genero)
        {
            _unit.GeneroRepository.Cadastrar(genero);
            _unit.Save();
            TempData["msg"] = "Genero cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        // GET: Genero
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}