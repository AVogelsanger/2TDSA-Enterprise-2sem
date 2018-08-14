using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        //Propriedades
        private decimal _taxa;
        private decimal _rendimento;

        public decimal Taxa
        {
            get { return _taxa; }
            set { _taxa = value; }
        }
        public decimal Rendimento
        {
            get { return _rendimento; }
            set { _rendimento = value; }
        }

        //Métodos
        public ContaPoupanca(decimal valor)
        {
            _rendimento = valor;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo >= 0)
            {
                Console.WriteLine("Valor insuficiente para saque.");
            }
            else
                Saldo -= valor;
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * Rendimento;
        }
    }
}
