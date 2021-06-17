using SalesWebMVC2.Models.Enums;
using System;

namespace SalesWebMVC2.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double MyProperty { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
    
        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double myProperty, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            MyProperty = myProperty;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
