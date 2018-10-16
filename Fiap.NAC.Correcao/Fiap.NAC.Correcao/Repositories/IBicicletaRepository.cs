using Fiap.NAC.Correcao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.NAC.Correcao.Repositories
{
    public interface IBicicletaRepository
    {
        void Cadastrar(Bicicleta bicicleta);
        IList<Bicicleta> Listar();
        void Remover(int codigo);
        IList<Bicicleta> BuscarPor(Expression<Func<Bicicleta,bool>> filtro);
    }
}
