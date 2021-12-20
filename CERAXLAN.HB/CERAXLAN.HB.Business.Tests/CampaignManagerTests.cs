using CERAXLAN.HB.Business.Concrete;
using CERAXLAN.HB.DataAccess.Abstract;
using CERAXLAN.HB.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Tests
{
    [TestClass]
    public class CampaignManagerTests
    {
        [TestMethod]
        public void Create_Campaign()
        {
            Mock<ICampaignDal> mock = new Mock<ICampaignDal>();
            CampaignManager campaignManager = new CampaignManager(mock.Object);

            campaignManager.Create(new Campaign());
        }
    }
}
