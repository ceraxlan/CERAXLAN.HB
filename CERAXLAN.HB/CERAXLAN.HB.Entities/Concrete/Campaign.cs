using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete
{
    public class Campaign
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public uint Duration { get; set; }
        public uint PriceManipulationLimit { get; set; }
        public uint TargetSalesCount { get; set; } 
        public DateTime CampaignStartDate { get; set; }
    }
}
