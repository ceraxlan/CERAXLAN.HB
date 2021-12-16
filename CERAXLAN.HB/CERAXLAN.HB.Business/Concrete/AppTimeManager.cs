using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.Core.Common.Response;
using CERAXLAN.HB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Concrete
{
    public class AppTimeManager : IAppTimeService
    {
        ICampaignService _campaignService;

        public AppTimeManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public uint GetTime()
        {
            return AppTime.time;
        }

        public ResultMessage IncreaseTime(uint value)
        {
            AppTime.time += value;
            _campaignService.ControlCampaigns();
            return new ResultMessage { Message = "Time is : " + GetTime() };
        }
    }
}
