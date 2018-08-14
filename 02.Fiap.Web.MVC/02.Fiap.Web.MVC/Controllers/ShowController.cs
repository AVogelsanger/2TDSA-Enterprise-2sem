using _02.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.Web.MVC.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        [HttpGet]//abre a porta com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]//recuperar as informações do formulário
        public ActionResult Cadastrar(Show show)
        {
            ViewBag.xereca = show.Banda;
            TempData["msg"] = "Show cadastrado!"; 
            return View(show);
            //return Content(show.Banda); //retorna um texto
        }
    }
}