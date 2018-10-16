using Fiap.NAC.Correcao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.NAC.Correcao.Repositories
{
    public interface ICategoriaRepository
    {
        void Cadastrar(Categoria categoria);
        IList<Categoria> Listar();
    }
}
