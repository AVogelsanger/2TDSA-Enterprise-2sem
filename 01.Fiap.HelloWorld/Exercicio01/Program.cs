using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente cc = new ContaCorrente();
            cc.Agencia = 0333;
            cc.DataAbertura = DateTime.Now;
            cc.Numero = 657559;
            cc.Saldo = 208914;
            cc.TipoConta = Model.TipoConta.Comum;

            var cp = new ContaPoupanca(0.006m)
            {
                Agencia = 1,
                Numero = 3,
                Saldo = 500,
                DataAbertura = new DateTime(2018,1,1),
                Taxa = 10
            };

            cc.Sacar(2000);
            Console.WriteLine(cp.Rendimento);
            Console.ReadLine();//ler o tecaldo
        }

    }
}
