using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Interface1.Services
{
    class Paypal : IPaymentService
    {

        public double Tax(double amount, int month)
        {
            amount += (amount * 0.01) * month;
            return amount + (amount * 0.02);
        }

    }
}
