using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1.Services
{
    interface IPaymentService
    {
        public double Tax(double amount, int month);
    }
}
