﻿using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Persistence
{
    public class FiapSenaContext : DbContext
    {
        public DbSet<Aposta> Apostas { get; set; }
        public DbSet<Concurso> Concursos { get; set; }
    }
}