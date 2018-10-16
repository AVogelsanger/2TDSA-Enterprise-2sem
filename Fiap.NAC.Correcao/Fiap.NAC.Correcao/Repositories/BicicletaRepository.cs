using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.NAC.Correcao.Models;
using Fiap.NAC.Correcao.Persistencia;

namespace Fiap.NAC.Correcao.Repositories
{
    public class BicicletaRepository : IBicicletaRepository
    {
        private FiapBikeContext _context;

        public BicicletaRepository(FiapBikeContext context)
        {
            _context = context;
        }

        public IList<Bicicleta> BuscarPor(Expression<Func<Bicicleta, bool>> filtro)
        {
            return _context.Bicicletas.Where(filtro).ToList();
        }

        public void Cadastrar(Bicicleta bicicleta)
        {
            _context.Bicicletas.Add(bicicleta);
        }

        public IList<Bicicleta> Listar()
        {
            return _context.Bicicletas.Include("Categoria").ToList();
        }

        public void Remover(int codigo)
        {
            var bike = _context.Bicicletas.Find(codigo);
            _context.Bicicletas.Remove(bike);
        }
    }
}