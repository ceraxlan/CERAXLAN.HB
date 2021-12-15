using CERAXLAN.HB.Business.Abstract;
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

        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }

        public Campaign Create(Campaign campaign)
        {
            return _campaignDal.Add(campaign);
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
    }
}
