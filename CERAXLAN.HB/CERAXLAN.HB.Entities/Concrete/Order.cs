using CERAXLAN.HB.Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete
{
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public uint Quantity { get; set; }     
    }
}
