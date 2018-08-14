using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de um aluno
            Aluno aluno = new Aluno("Bart Simpson");
            aluno.Nome = "Bart Simpson"; //set
            Console.WriteLine(aluno.Nome); //get

            //Instancia de um professor
            Professor prof = new Professor("Girafales")
            {
                Nome = "Girafales",
                Idade = 55
            };
            

        }
    }
}
