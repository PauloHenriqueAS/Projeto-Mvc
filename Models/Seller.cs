using System;
using System.Collections.Generic;

namespace projetoFinalUdemy.Models
{
    class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public List<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
            this.BaseSalary = baseSalary;
        }

        public void addSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void removeSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            double totalAmount = 0;
            foreach(SalesRecord sr in Sales)
            {
               totalAmount += sr.Amount;
            }
            return totalAmount;
        }
    }
}