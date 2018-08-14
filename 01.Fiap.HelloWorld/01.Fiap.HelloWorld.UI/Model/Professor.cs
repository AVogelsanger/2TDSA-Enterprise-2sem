using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Professor : Pessoa, ITrabalhador
    {
        public IList<string> Disciplinas { get; set; }


        //Construtor
        public Professor(String nome) : base(nome)
        {

        }

        //Métodos
        public override void FazerProva()
        {
            Console.WriteLine("Professor fazendo a prova");
        }

        public void ReceberSalario()
        {
            Console.WriteLine("Ganhando cesta básica.");
        }
    }
}
