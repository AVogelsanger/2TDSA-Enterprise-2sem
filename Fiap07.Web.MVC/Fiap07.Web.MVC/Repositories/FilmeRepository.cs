using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;

namespace Fiap07.Web.MVC.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        private FiaplixContext _context;

        public FilmeRepository(FiaplixContext context)
        {
            _context = context;
        }

        public void Atualizar(Categoria filme)
        {
            _context.Entry(filme).State = EntityState.Modified;
        }

        public IList<Categoria> BuscarPor(Expression<Func<Categoria, bool>> filtro)
        {
            return _context.Filmes.Where(filtro).ToList();
        }

        public Categoria BuscarPorNumero(int numero)
        {
            return _context.Filmes.Find(numero);
        }

        public void Cadastrar(Categoria filme)
        {
            _context.Filmes.Add(filme);
        }

        public void Excluir(int numero)
        {
            var filme = BuscarPorNumero(numero);
            _context.Filmes.Remove(filme);
        }

        public IList<Categoria> Listar()
        {
            return _context.Filmes.ToList();
        }
    }
}