using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using LINQ1.Entities;
using System.Globalization;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(path);
            List<Product> products = new List<Product>();
            foreach(string a in lines)
            {
                string[] fields = a.Split(';');
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));
            }
            Console.WriteLine("Average price: " + products.Average(p => p.price).ToString("F2"));
            var r1 = products.Where(p => p.price < products.Average(p => p.price)).OrderByDescending(p => p.name);
            foreach(Product a in r1)
            {
                Console.WriteLine(a.name);
            }
        }
    }
}
