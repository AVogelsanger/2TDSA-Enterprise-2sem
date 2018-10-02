using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public Categoria categoria { get; set; }
        public ClassificacaoIndicativa classificacaoIndicativa { get; set; }
    }
}