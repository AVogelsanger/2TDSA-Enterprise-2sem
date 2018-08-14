using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {
        //campo atributos 
        private int _agencia;
        private DateTime _dataAbertura;
        private int _numero;
        private decimal _saldo;

        //Propriedades (gets e sets)
        public int Agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }
        public DateTime DataAbertura
        {
            get { return _dataAbertura; }
            set { _dataAbertura = value; }
        }
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        //Construtores
        public Conta()
        {
            Agencia = _agencia;
            DataAbertura = _dataAbertura;
            Numero = _numero;
            Saldo = _saldo;
        }

        public abstract void Depositar(decimal valor);

        public abstract void Sacar(decimal valor);
    }
}
