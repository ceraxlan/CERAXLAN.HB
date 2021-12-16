using CERAXLAN.HB.Core.Common.Response;
using CERAXLAN.HB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Abstract
{
    public interface IApplicationService
    {
        uint GetTime();      
        void CheckCampaigns();
        ResultMessage CreateProduct(Product product);
        ResultMessage GetProductInfo(string productCode);
        ResultMessage CreateOrder(Order order);
        ResultMessage CreateCampaign(Campaign campaign);
        ResultMessage GetCampaignInfo(string name);
        ResultMessage IncreaseTime(uint value);
    }
}
