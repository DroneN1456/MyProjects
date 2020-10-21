using System;
using System.Collections.Generic;
using System.Text;

namespace BancoApp
{
    class Banco
    {
        private double _saldo;
        public int NumeroConta { get; }
        public string Nome { get; set; }


        public Banco(int numeroConta, string nome, double saldo)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            _saldo += saldo;
        }

        public double Sacar(double saldo)
        {
            return _saldo -= (saldo + 5.00);
        }
        public double Depositar(double saldo)
        {
            return _saldo += saldo;
        }
        public override string ToString()
        {
            return "Titular: " + Nome + ", " + "Numero da conta: " + NumeroConta + ", " + "Saldo : R$" + _saldo;
        }

    }
}
