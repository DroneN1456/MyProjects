using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sitezada.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Range(100.0, 50000.00, ErrorMessage = "{0} must be from {1} to {2}")]
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Salary { get; set; }


        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public Seller()
        {

        }
        public Seller(int Id, string Name, string Email, DateTime BirthDate, double Salary, Department Department)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.BirthDate = BirthDate;
            this.Salary = Salary;
            this.Department = Department;
        }

        public void AddSales (SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales (SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales (DateTime start, DateTime finish)
        {
            return Sales.Where(xD => xD.Date >= start && xD.Date <= finish).Sum(xD => xD.Amount);
        }
    }
}
