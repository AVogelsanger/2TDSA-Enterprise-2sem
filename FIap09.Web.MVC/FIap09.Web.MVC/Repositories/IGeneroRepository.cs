using FIap09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIap09.Web.MVC.Repositories
{
    public interface IGeneroRepository
    {
        void Cadastrar(Genero genero);
        IList<Genero> Listar();
    }
}
