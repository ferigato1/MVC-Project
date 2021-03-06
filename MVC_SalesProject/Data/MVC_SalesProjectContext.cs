using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MVC_SalesProject.Models
{
    public class MVC_SalesProjectContext : DbContext
    {
        public MVC_SalesProjectContext (DbContextOptions<MVC_SalesProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet <Seller> Seller { get; set; }
        public DbSet <SalesRecord> SalesRecord { get; set; }
    }
}
