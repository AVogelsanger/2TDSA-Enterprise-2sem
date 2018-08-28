using Fiap04.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap04.Web.MVC.Persistencia
{
    public class ImigracaoContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Pais> Paises { get; set; }
    }
}