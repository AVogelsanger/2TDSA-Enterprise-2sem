using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using FIap09.Web.MVC.Models;
using FIap09.Web.MVC.Persistence;

namespace FIap09.Web.MVC.Repositories
{
    public class JogoRepository : IJogoRepository
    {

        private JogoContext _context;

        public JogoRepository(JogoContext context)
        {
            _context = context;
        }

        public void Atualizar(Jogo jogo)
        {
            _context.Entry(jogo).State = EntityState.Modified;
        }

        public Jogo BuscarPorCodigo(int jogoId)
        {
            return _context.Jogos.Find(jogoId);
        }

        public IList<Jogo> BuscarPorQualquerCoisa(Expression<Func<Jogo, bool>> predicate)
        {
            return _context.Jogos.Where(predicate).ToList();
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        public IList<Jogo> Listar()
        {
            return _context.Jogos.ToList();
        }

        public void Remover(int jogoId)
        {
            Jogo jogo = _context.Jogos.Find(jogoId);
            _context.Jogos.Remove(jogo);
        }
    }
}