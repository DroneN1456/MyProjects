using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSys.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct (string name, double price, DateTime manufacturedate) : base (name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string priceTag()
        {
            return Name + "(Used) $ " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy)");
        }
    }
}
