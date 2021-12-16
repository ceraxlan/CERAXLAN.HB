using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Entities.Concrete.ViewModels
{
    public class CampaignInfoView
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public uint TargetSales { get; set; }
        public uint TotalSales { get; set; }
        public uint Turnover { get; set; }
        public uint AverageItemPrice { get; set; }
    }
}
