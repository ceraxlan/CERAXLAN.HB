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
        public int Duration { get; set; }
        public int PriceManipulationLimit { get; set; }
        public int TargetSalesCount { get; set; }
        public int TotalSales { get; set; }
        public int TotalPayment { get; set; }
        public string Status { get; set; } = "Active";
        public int Turnover { get; set; } = 0;

    }
}
