using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Persistencia
{
    public class FiaplixContext : DbContext
    {
        public DbSet<Categoria> Filmes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}