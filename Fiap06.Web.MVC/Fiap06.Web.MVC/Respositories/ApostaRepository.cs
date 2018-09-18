using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistence;

namespace Fiap06.Web.MVC.Respositories
{
    public class ApostaRepository : IApostaRepository
    {
        private FiapSenaContext _context;

        public ApostaRepository(FiapSenaContext context) 
        {
            _context = context;
        }

        public void Atualizar(Aposta aposta)
        {
            _context.Entry(aposta).State = EntityState.Modified;
        }

        public IList<Aposta> BuscarPor(Expression<Func<Aposta, bool>> filtro)
        {
            return _context.Apostas.Where(filtro).ToList();
        }

        public Aposta BuscarPorNumero(int numero)
        {
            return _context.Apostas.Find(numero);
        }

        public void Cadastrar(Aposta aposta)
        {
            _context.Apostas.Add(aposta);
        }

        public void Excluir(int numero)
        {
            var aposta = BuscarPorNumero(numero);
            _context.Apostas.Remove(aposta);
        }

        public IList<Aposta> Listar()
        {
            return _context.Apostas.ToList();
        }
    }
}