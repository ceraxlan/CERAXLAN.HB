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
    public class Order :OrderBase, IEntity
    {
        [Key]
        public int Id { get; set; }
              
    }
}
