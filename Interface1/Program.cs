using Interface1.Entities;
using Interface1.Services;
using System;
using System.Globalization;
using System.Xml;

namespace Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Number of installments: ");
            int x = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value, new Paypal());

            for(int i = 1; i <= x; i++)
            {
                double parcela = value / x;
                contract.addInstallment(parcela, i);
            }
            foreach(Installment parc in contract.installments)
            {
                Console.WriteLine(parc);
            }


        }
    }
}
