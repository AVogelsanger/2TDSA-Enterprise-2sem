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
    public class CategoriaRepository : ICategoriaRepository
    {
        private FiaplixContext _context;

        public CategoriaRepository(FiaplixContext context)
        {
            _context = context;
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Entry(categoria).State = EntityState.Modified;
        }

        public IList<Categoria> BuscarPor(Expression<Func<Categoria, bool>> filtro)
        {
            return _context.Categorias.Where(filtro).ToList();
        }

        public Categoria BuscarPorNumero(int numero)
        {
            return _context.Categorias.Find(numero);
        }

        public void Cadastrar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
        }

        public void Excluir(int numero)
        {
            var categoria = BuscarPorNumero(numero);
            _context.Categorias.Remove(categoria);
        }

        public IList<Categoria> Listar()
        {
            return _context.Categorias.ToList();
        }
    }
}