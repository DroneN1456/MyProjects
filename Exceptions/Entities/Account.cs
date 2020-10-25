using Exceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Exceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;
        }
        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value > WithdrawLimit)
            {
                throw new DomainException("Valor do saque não pode ser maior que o limite da conta"!);
            }

            if (value > Balance)
            {
                throw new DomainException("Valor do saque não pode ser maior que o valor do saldo da conta!");
            }

            Balance -= value;
             
        }

    }
}
