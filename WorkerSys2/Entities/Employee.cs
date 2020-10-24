using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerSys2.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return ValuePerHour * Hours;
        }

        public sealed override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " - $" + payment());
            return sb.ToString();
        }

    }
}
