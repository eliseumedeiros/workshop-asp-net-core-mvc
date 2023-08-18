using System;

namespace SalesWebMvcApp.Models
{
    public class SalesRecord
    {
        public int Id{ get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesRecord Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesRecord status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
