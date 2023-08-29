using SalesProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SalesProject.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public SalesStatus Status { get; set; }

        public double Amount { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord (int id, DateTime date, SalesStatus status, double amount, Seller seller)
        {
            Id = id;
            Date = date;
            Status = status;
            Amount = amount;
            Seller = seller;
        }
    }

   
}
