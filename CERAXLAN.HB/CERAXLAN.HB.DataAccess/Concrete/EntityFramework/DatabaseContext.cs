using CERAXLAN.HB.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("User Id=ceraslan; Password=ceraxlan; Server=CERAXLAN; Database=HB; Integrated Security=True; Connection Timeout=60;");
        }
    }
}
