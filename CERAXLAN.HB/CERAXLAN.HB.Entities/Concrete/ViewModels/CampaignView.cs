using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete.ViewModels
{
    public class CampaignView
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Duration { get; set; }
        public int Limit { get; set; }
        public int TargetSalesCount { get; set; }
        
    }
}
