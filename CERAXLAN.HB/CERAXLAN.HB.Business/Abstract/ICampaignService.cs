using CERAXLAN.HB.Core.Common.Response;
using CERAXLAN.HB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Abstract
{
    public interface ICampaignService
    {
        List<Campaign> GetAll();
        Campaign Get(string name);
        Campaign Create(Campaign campaign);
        Campaign Update(Campaign campaign);
        void Delete(Campaign campaign);
        bool IsExistName(string name);
        bool IsActiveCampaign(string name);
        Campaign GetCampaignWithProductCode(string productCode);
       
    }
}
