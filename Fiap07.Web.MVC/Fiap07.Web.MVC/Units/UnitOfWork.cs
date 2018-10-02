using Fiap07.Web.MVC.Persistencia;
using Fiap07.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {

        private FiaplixContext _context = new FiaplixContext();

        private IFilmeRepository _filmeRepository;

        private ICategoriaRepository _categoriaRepository;


        public IFilmeRepository FilmeRepository
        {
            get
            {
                if(_filmeRepository == null)
                {
                    _filmeRepository = new FilmeRepository(_context);
                }
                return _filmeRepository;
            }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                if (_categoriaRepository == null)
                {
                    _categoriaRepository = new CategoriaRepository(_context);
                }
                return _categoriaRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}