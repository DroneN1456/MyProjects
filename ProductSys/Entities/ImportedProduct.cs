using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSys.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct (string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2") + " (" + "Custom fee: $ " + CustomsFee + ")";
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
