using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FIap09.Web.MVC.Models;
using FIap09.Web.MVC.Persistence;

namespace FIap09.Web.MVC.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private JogoContext _context;

        public GeneroRepository(JogoContext context)
        {
            _context = context;
        }

        public void Cadastrar(Genero genero)
        {

            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            return _context.Generos.ToList();
        }
    }
}