using CERAXLAN.HB.Core.Entities;
using CERAXLAN.HB.Entities.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete
{
    public class Product :ProductBase, IEntity
    {     
        public int FirstPrice { get; set; }
        public bool ProductDiscount { get; set; } = false;

    }
}
