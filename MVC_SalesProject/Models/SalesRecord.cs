using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_SalesProject.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVC_SalesProject.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Amount { get; set; }

        //Association SalesRecord(*) -> Status(1)
        public SaleStatus Status { get; set; }

        //Association SalesRecord(*) -> Seller(1)
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
