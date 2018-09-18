using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    public class Aposta
    {
        public int ApostaId { get; set; }
        public DateTime Data { get; set; }
        public IList<int> Sequencia { get; set; }
        //Relacionamento
        public Concurso Concurso { get; set; }
        public int Numero { get; set; }
    }
}