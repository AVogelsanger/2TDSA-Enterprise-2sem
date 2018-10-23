using FIap09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FIap09.Web.MVC.Repositories
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);
        void Atualizar(Jogo jogo);
        Jogo BuscarPorCodigo(int jogoId);
        void Remover(int jogoId);
        IList<Jogo> Listar();
        IList<Jogo> BuscarPorQualquerCoisa (Expression<Func<Jogo, bool>> predicate);
        
    }
}
