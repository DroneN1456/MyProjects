using System;
using System.Dynamic;
using WokerSys.Entities;

namespace WokerSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's name : ");
            string depName = Console.ReadLine();
            Department department = new Department(depName);
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junir/MidLevel/Senior): ");
            string level = Console.ReadLine();
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, baseSalary);
            Console.Write("How many contracts to this worker? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + "# contract data:");
                Console.Write("Date(DD/MM/YYYY): ");
                string date = Console.ReadLine();
                DateTime dateTime = DateTime.Parse(date);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(dateTime, valuePerHour, hour);
                worker.AddContract(contract);
            }
            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + department.Name);
            double income = worker.income(date2);
            Console.WriteLine("Income for " + date2.ToString("MM/yyyy") + ":" + " " + "R$" + income);
        }
    }
}
