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
        public int TargetSales { get; set; }
        public int TotalSales { get; set; }
        public int Turnover { get; set; }
        public int AverageItemPrice { get; set; }
    }
}
