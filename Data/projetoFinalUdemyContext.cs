using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace projetoFinalUdemy.Models
{
    public class projetoFinalUdemyContext : DbContext
    {
        public projetoFinalUdemyContext (DbContextOptions<projetoFinalUdemyContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord {get; set;}
        public DbSet<Seller> Seller {get; set;}
    }
}