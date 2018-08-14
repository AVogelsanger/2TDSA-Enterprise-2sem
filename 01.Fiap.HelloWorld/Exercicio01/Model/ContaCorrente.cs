using Exercicio01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta
    {
        //Propriedades
        public TipoConta TipoConta{ get; set; }

        //Métodos
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Sacar(decimal valor)
        {
            if(Saldo >= 0)
            {
                Console.WriteLine("Valor insuficiente para saque.");
            }
            else
            Saldo -= valor;
        }
    }
}
