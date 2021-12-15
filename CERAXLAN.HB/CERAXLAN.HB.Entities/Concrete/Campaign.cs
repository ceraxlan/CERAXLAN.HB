using CERAXLAN.HB.Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete
{
    public class Campaign : IEntity
    {       
        [Key]
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public uint Duration { get; set; }
        public double PriceManipulationLimit { get; set; }
        public uint TargetSalesCount { get; set; }
        
    }
}
