using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    abstract class Pessoa
    {
        //Campo (Atributo)
        private string _nome;

        //Propriedades (gets e sets)
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Genero Genero { get; set; }

        public int Idade { get; set; }

        //Construtores

        public Pessoa(String nome)
        {
            Nome = nome;
        }
        
        public virtual void Estudar()
        {
            Console.WriteLine("Pessoa estudando");
        }

        public abstract void FazerProva();
        
    }
}
