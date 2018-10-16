using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.NAC.Correcao.Models;
using Fiap.NAC.Correcao.Persistencia;

namespace Fiap.NAC.Correcao.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private FiapBikeContext _context;

        public CategoriaRepository(FiapBikeContext context)
        {
            _context = context;
        }

        public void Cadastrar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
        }

        public IList<Categoria> Listar()
        {
            return _context.Categorias.ToList();
        }
    }
}