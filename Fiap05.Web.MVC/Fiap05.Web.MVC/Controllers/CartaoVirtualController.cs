using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoVirtualController : Controller
    {
        private FiapBankContext _context = new FiapBankContext();

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.CartoesVirtuais.Include("CartaoReal").ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os cartoes reais do banco
            var lista = _context.CartoeReais.ToList();
            //Enviar para a pag através do viewbag
            ViewBag.listaCartao = new SelectList(lista, "CartaoRealId", "Numero");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CartaoVirtual cartao)
        {
            _context.CartoesVirtuais.Add(cartao);
            _context.SaveChanges();
            TempData["msg"] = "Cartão virtual cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }
    }
}