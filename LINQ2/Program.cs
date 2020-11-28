using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using LINQ2.Entities;

namespace LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(path);
            List<Employee> employees = new List<Employee>();
            foreach (string a in lines)
            {
                string[] fields = a.Split(';');
                string name = fields[0];
                string email = fields[1];
                double salario = double.Parse(fields[2], CultureInfo.InvariantCulture);
                employees.Add(new Employee(name, email, salario));
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is more than " + salary + ":");
            var r1 = employees.Where(p => p.salary > salary).OrderBy(p => p.name);
            foreach(Employee a in r1)
            {
                Console.WriteLine(a.email);
            }

            var r2 = employees.Where(p => p.name[0] == 'M').Sum(p => p.salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M' : " + r2.ToString("F2"));
        }
    }
}
