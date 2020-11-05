using Interface1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1.Entities
{
    class Contract
    {
        int number { get; set; }
        DateTime date { get; set; }
        private DateTime _date;
        double totalValue { get; set; }
        public List<Installment> installments = new List<Installment>();
        private IPaymentService _paymentService;

        public Contract(int number, DateTime date, double totalValue, IPaymentService paymentService)
        {
            this.number = number;
            this.date = date;
            _date = date;
            this.totalValue = totalValue;
            _paymentService = paymentService;
        }

       public void addInstallment(double amount, int mes)
        {
            _date = _date.AddMonths(1);
            installments.Add(new Installment(_date, _paymentService.Tax(amount, mes)));
        }


    }
}
