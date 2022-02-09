using CERAXLAN.HB.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext :DbContext
    {
        
        public DbSet<Order> Orders { get; set; }     
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Product> Products { get; set; }
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

        }
    }
}
