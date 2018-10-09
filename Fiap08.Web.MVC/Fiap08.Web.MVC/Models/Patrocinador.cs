using System.Collections.Generic;

namespace Fiap08.Web.MVC.Models
{
    public class Patrocinador
    {
        public int PatrocinadorId { get; set; }
        public string nome { get; set; }
        public IList<Projeto> Projetos { get; set; }
    }
}