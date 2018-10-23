using FIap09.Web.MVC.Persistence;
using FIap09.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIap09.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {

        private JogoContext _context = new JogoContext();
        private IJogoRepository _jogoRepository;
        private IGeneroRepository _generoRepository;

        public IJogoRepository JogoRepository
        {
            get
            {
                if(_jogoRepository == null)
                {
                    _jogoRepository = new JogoRepository(_context);
                }
                return _jogoRepository;
            }
        }

        public IGeneroRepository GeneroRepository
        {
            get
            {
                if(_generoRepository == null)
                {
                    _generoRepository = new GeneroRepository(_context);
                }
                return _generoRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}