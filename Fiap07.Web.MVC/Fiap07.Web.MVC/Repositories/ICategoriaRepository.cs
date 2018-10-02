using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repositories
{
    public interface ICategoriaRepository
    {
        void Cadastrar(Categoria categoria);
        void Atualizar(Categoria categoria);
        Categoria BuscarPorNumero(int numero);
        void Excluir(int numero);
        IList<Categoria> Listar();
        IList<Categoria> BuscarPor(Expression<Func<Categoria, bool>> filtro);
    }
}