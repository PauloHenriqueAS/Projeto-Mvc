using System;

namespace projetoFinalUdemy.Models
{
    class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status)
        {
            this.Id = id;
            this.Date = date;
            this.Amount = amount;
            this.Status = status;
        }
    }

    enum SaleStatus : int {
        Pending,
        Billed,
        Canceled
    }
}