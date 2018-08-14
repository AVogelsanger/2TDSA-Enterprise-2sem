using _02.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _02.Fiap.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Login login)
        {
            if(login.usuario == "Fiap" && login.senha == "Fiap123")
            {
                return View("Inicio");
            }
            else
            {
                TempData["msg"] = "Senha ou usuário inválidos!";
            }
            return View();
        }
    }
}