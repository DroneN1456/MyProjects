using OrderSys.entities.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSys.entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double totalValor = 0;
            foreach (OrderItem x in items)
            {
                totalValor += x.subTotal();
            }
            return totalValor;
        }

        public override string ToString()
        {
            double totalvalor = total();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client " + Client);
            foreach(OrderItem x in items)
            {
                sb.AppendLine(x.ToString());
            }
            sb.AppendLine("Total price: " + totalvalor);

            return sb.ToString();
        }
    }
}
