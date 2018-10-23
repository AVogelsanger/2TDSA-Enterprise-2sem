using FIap09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIap09.Web.MVC.Persistence
{
    public class JogoContext : DbContext
    {
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}