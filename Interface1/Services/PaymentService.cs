using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1.Services
{
    interface PaymentService
    {
        public double Tax(double amount, int month);
    }
}
