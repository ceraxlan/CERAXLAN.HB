using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Bases
{
    public abstract class OrderBase
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
    }
}
