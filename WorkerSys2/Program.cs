using System;
using System.Collections.Generic;
using System.Threading;
using WorkerSys2.Entities;

namespace WorkerSys2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + " data:");
                Console.Write("Outsourced (y/n)? ");
                string response = Console.ReadLine();
                response = response.ToUpper();
                bool outsourced = response == "Y";
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhours = double.Parse(Console.ReadLine());
                double additionalcharge = 0;
                if (outsourced == true)
                {
                    Console.Write("Additional charge: ");
                    additionalcharge = double.Parse(Console.ReadLine());
                    Employee employee = new OutSourceEmployee(name, hours, valueperhours, additionalcharge);
                    employees.Add(employee);
                   
                }

                else
                {
                    Employee employee = new Employee(name, hours, valueperhours);
                    employees.Add(employee);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments:");
            foreach (Employee x in employees)
            {
                Console.WriteLine(x);
            }
        }
    }
}
