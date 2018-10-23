using FIap09.Web.MVC.Models;
using FIap09.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIap09.Web.MVC.Controllers
{
    public class JogoController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Buscar(string nome)
        {
            var lista = _unit.JogoRepository.BuscarPorQualquerCoisa(j => j.Nome.Contains(nome));
            return View(lista);
        }

        [HttpGet]
        public ActionResult Buscar(int id)
        {
            var lista = _unit.JogoRepository.BuscarPorCodigo(id);
            return View(lista);
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            _unit.JogoRepository.Remover(id);
            _unit.Save();
            return RedirectToAction("Lista");
        }
       
        [HttpPost]
        public ActionResult Atualizar(Jogo jogo)
        {
            _unit.JogoRepository.Atualizar(jogo);
            _unit.Save();
            return RedirectToAction("Lista");
        }

        public ActionResult Lista()
        {
            return View(_unit.JogoRepository.Listar());
        }

        public ActionResult Cadastrar(Jogo jogo)
        {
            _unit.JogoRepository.Cadastrar(jogo);
            _unit.Save();
            TempData["msg"] = "GAME cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        // GET: Jogo
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.Generos = new SelectList(_unit.GeneroRepository.Listar(), "GeneroId", "Nome");
            return View();
        }
    }
}