using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WokerSys.Entities
{
    class Worker
    {
        List<HourContract> Contracts = new List<HourContract>();
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Worker (string name, string level, double baseSalary)
        {
            Name = name;
            Level = Enum.Parse<WorkerLevel>(level);
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(DateTime date)
        {
            DateTime searchDate = date;
            double valorTotal = 0;
            foreach(HourContract contrato in Contracts)
            {
                if (contrato.Date.Year == searchDate.Year && contrato.Date.Month == searchDate.Month)
                {
                    valorTotal += contrato.totalValue();
                }
            }
            return valorTotal;
        
        }
    }
}
