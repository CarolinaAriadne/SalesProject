using SalesProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace SalesProject.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public SalesStatus Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }

        public Seller Seller { get; set; }
        public int V1 { get; }
        public DateTime DateTime { get; }
        public double V2 { get; }
        public SalesStatus Billed { get; }
        public Seller S1 { get; }

        public SalesRecord()
        {

        }

        public SalesRecord (int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Status = status;
            Amount = amount;
            Seller = seller;
        }

     
    }

   
}
