using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuSitezinho.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
