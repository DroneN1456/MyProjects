using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ2.Entities
{
    class Employee
    {
        public string name { get; set; }
        public string email { get; set; }
        public double salary { get; set; }

        public Employee (string name, string email, double salary)
        {
            this.name = name;
            this.email = email;
            this.salary = salary;
        }
    }
}
