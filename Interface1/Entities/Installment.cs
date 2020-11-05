using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1.Entities
{
    class Installment
    {
        DateTime dueDate { get; set; }
        double amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }

        public override string ToString()
        {
            return dueDate.ToString("dd/MM/yyyy") + " - " + amount.ToString("F2");
        }
    }
}
