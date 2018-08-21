using FIap03.Web.MVC.Exercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIap03.Web.MVC.Exercicio.Controllers
{
    public class RefeicaoController : Controller
    {
        // GET: Refeicao

        public ActionResult Listar()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Refeicao refeicao)
        {
            return View();
        }

    }
}