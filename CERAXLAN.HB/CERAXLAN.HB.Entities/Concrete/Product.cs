using CERAXLAN.HB.Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public string ProductCode { get; set; }
        public double Price { get; set; } 
        public uint Stock { get; set; } 

    }
}
