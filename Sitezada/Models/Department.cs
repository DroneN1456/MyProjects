using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitezada.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        
        public Department()
        {

        }

        public Department(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void AddSeller(Seller Seller)
        {
            Sellers.Add(Seller);
        }
        public double TotalSales(DateTime start, DateTime Finish)
        {
            return Sellers.Sum(a => a.TotalSales(start, Finish));
        }
    }
}
