using Fiap04.Web.MVC.Models;
using Fiap04.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap04.Web.MVC.Controllers
{
    public class PessoaController : Controller
    {
        private ImigracaoContext _context = new ImigracaoContext();

        [HttpGet]
        public ActionResult Pesquisar(string nomeBusca)
        {
            // fazer a busca por nome e retornar a lista para a página
            var lista = _context.Pessoas.Where(p => nomeBusca.Contains(nomeBusca)).ToList();
            return View("Listar",lista);
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
            TempData["msg"] = "Cadastro excluído!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Alterar(Pessoa pessoa)
        {
            _context.Entry(pessoa).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Cadastro de pessoa atualizado.";
            return RedirectToAction("cadastrar");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            return View(pessoa);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Pessoas.ToList();
            return View(lista);
        }

        // GET: Pessoa
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("cadastrar");
        }
    }
}