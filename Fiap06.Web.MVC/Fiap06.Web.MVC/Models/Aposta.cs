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

        public IList<int> _sequencia { get; set; }

        private string _sequenciaString;

        private IList<int> Sequencia
        {
            get { return _sequencia; }
            set
            {
                _sequencia = value;
                //Gera um string com os números do array separados por vírgula
                SequenciaString = string.Join(",", Sequencia.ToArray());
            }
        }
        public string SequenciaString
        {
            set
            {
                _sequenciaString = value;
                //Transforma uma string em uma lista de inteiros
                _sequencia = _sequenciaString.Split(',').Select(Int32.Parse).ToList();
            }
            get
            {
                return _sequenciaString;
            }
        }
        //Relacionamento
        public Concurso Concurso { get; set; }
        public int Numero { get; set; }
    }
}