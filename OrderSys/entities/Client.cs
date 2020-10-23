using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSys.entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            birthDate = birthdate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name + " " + birthDate.ToString("(dd/MM/yyyy)") + " " + Email);
            return sb.ToString();
        }
    }
}
