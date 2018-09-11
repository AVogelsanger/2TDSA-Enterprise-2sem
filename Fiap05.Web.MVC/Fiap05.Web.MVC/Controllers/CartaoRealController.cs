using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoRealController : Controller
    {
        private FiapBankContext _context = new FiapBankContext();


        [HttpPost]
        public ActionResult Bloquear(int id)
        {
            var cartao = _context.CartoeReais.Find(id);
            if (cartao.Status == StatusCartao.Aprovado)
            {
                cartao.Status = StatusCartao.Bloqueado;
                _context.Entry(cartao).State = EntityState.Modified;
                _context.SaveChanges();
                TempData["msg"] = "Cartão bloqueado!";
            }

            return RedirectToAction("Listar");
        }


        [HttpPost]
        public ActionResult Aprovar(int id)
        {
            var cartao = _context.CartoeReais.Find(id);
            if(cartao.Status == StatusCartao.Bloqueado)
            {
                cartao.Status = StatusCartao.Aprovado;
                _context.Entry(cartao).State = EntityState.Modified;
                _context.SaveChanges();
                TempData["msg"] = "Cartão aprovado!";
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.CartoeReais.ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CartaoReal cartao)
        {
            cartao.Status = StatusCartao.Bloqueado;
            _context.CartoeReais.Add(cartao);
            _context.SaveChanges();
            TempData["msg"] = "Cartão real cadastrado com sucesso!!";
            return RedirectToAction("cadastrar");
        }
    }
}