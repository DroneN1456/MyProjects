using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSys.entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Produto { get; set; }

        public OrderItem(int quantity, double price, Product produto)
        {
            Quantity = quantity;
            Price = price;
            Produto = produto;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            double subtotal = subTotal();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Produto.Name}, ${Price}, Quantity: {Quantity}, Subtotal: ${subtotal.ToString("F2")}");
            return sb.ToString();
        }
    }
}
