using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete
{
    public class Product
    {
        public string ProductCode { get; set; }
        public uint Price { get; set; }
        public uint Stock { get; set; }
    }
}
