using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Bases
{
    public abstract class ProductBase
    {
        [Key]
        public string ProductCode { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
