using System.Collections;
using System.Collections.Generic;

namespace FIap09.Web.MVC.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nome { get; set; }
        public virtual IList<Jogo> Jogos{ get; set; }
    }
}