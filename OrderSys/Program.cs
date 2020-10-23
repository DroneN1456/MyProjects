using OrderSys.entities;
using OrderSys.entities.enums;
using System;

namespace OrderSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthdate);
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;
            Order pedido = new Order(moment, status, client);
            Console.Write("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + "# data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Product produto = new Product(pName, price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price, produto);
                pedido.addItem(orderItem);

            }

            Console.WriteLine("");
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(pedido);

        }
    }
}
