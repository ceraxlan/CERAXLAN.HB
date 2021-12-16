using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.Business.ValidationRules.FluentValidation;
using CERAXLAN.HB.Core.Aspects.Postsharp.ValidationAspects;
using CERAXLAN.HB.Core.Common.Response;
using CERAXLAN.HB.DataAccess.Abstract;
using CERAXLAN.HB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private ICampaignDal _campaignDal;
        private IProductService _productService;

        public CampaignManager(ICampaignDal campaignDal, IProductService productService)
        {
            _campaignDal = campaignDal;
            _productService = productService;
        }

        [FluentValidationAspect(typeof(CampaignValidator))]
        public ResultMessage Create(Campaign campaign)
        {
            return new ResultMessage { Message = "Campaign created ", Result = _campaignDal.Add(campaign) };
        }

        public void Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
        }

        public Campaign Get(string name)
        {
            return _campaignDal.Get(c => c.Name == name);
        }

        public List<Campaign> GetAll()
        {
            return _campaignDal.GetList();
        }

        public Campaign Update(Campaign campaign)
        {
            return _campaignDal.Update(campaign);
        }
        public bool IsExistName(string name)
        {
            return _campaignDal.Get(p => p.Name == name) == null ? true : false;
        }

        public bool IsActiveCampaign(string name)
        {
            var campaing = Get(name);
            
            return (campaing.Duration > AppTime.time) && (campaing.TargetSales < campaing.TargetSalesCount) ? true : false;
            
        }

        public Campaign GetCampaignWithProductCode(string productCode)
        {
            return _campaignDal.Get(c => c.ProductCode == productCode);
        }

        public void ControlCampaigns()
        {
            var campaignList = GetAll();
            foreach (var campaign in campaignList)
            {
                var result = IsActiveCampaign(campaign.Name);
                if (result) { _productService.Get(campaign.ProductCode); } // devamke
            }
        }
    }
}
