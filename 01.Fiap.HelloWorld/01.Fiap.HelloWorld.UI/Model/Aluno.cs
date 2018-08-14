using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Aluno : Pessoa
    {
        //Propriedade
        public int Rm { get; set; }
        public decimal Mensalidade { get; set; }

        //Construtor
        public Aluno(String nome) : base (nome)
        {
            Rm = Rm;
        }

        //Métodos
        public override void FazerProva()
        {
            Console.WriteLine("Aluno respondendo a prova");
        }

        public override void Estudar()
        {
            Console.WriteLine("Aluno estudando ainda mais!");
        }
    }
}
