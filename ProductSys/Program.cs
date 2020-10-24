using ProductSys.Entities;
using System;
using System.Collections.Generic;

namespace ProductSys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Product #" + (i + 1) + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string rsp = Console.ReadLine();
                rsp = rsp.ToUpper();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (rsp == "I")
                {
                    Console.Write("Customs fee: ");
                    double customfee = double.Parse(Console.ReadLine());
                    Product produto = new ImportedProduct(name, price, customfee);
                    products.Add(produto);
                }
                else if (rsp == "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedate = DateTime.Parse(Console.ReadLine());
                    Product produto = new UsedProduct(name, price, manufacturedate);
                    products.Add(produto);
                }
                else
                {
                    Product produto = new Product(name, price);
                    products.Add(produto);
                }

              
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product x in products)
            {
                Console.WriteLine(x.priceTag());
            }

        }

        
    }
}
