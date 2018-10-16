using Fiap.NAC.Correcao.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.NAC.Correcao.Repositories;

namespace Fiap.NAC.Correcao.Units
{
    public class UnitOfWork : IDisposable
    {
        private FiapBikeContext _context = new FiapBikeContext();

        private ICategoriaRepository _categoriaRepository;
        private IBicicletaRepository _bicicletaRepository;

        public IBicicletaRepository BicicletaRepository
        {
            get
            {
                if(_bicicletaRepository == null)
                {
                    _bicicletaRepository = new BicicletaRepository(_context);
                }
                return _bicicletaRepository;
            }
            
        }


        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                if(_categoriaRepository == null)
                {
                    _categoriaRepository = new CategoriaRepository(_context);
                }
                    return _categoriaRepository;
            }
            
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}