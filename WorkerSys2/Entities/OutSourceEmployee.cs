using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerSys2.Entities
{
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return (AdditionalCharge * 1.10) + base.payment();
        }

    }
}
