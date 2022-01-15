﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SalesProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        //Association Departament(1) -> Seller(*)
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initital, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initital, final));
        }
    }
}
