using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.Business.Concrete;
using CERAXLAN.HB.DataAccess.Abstract;
using CERAXLAN.HB.Entities.Concrete;
using FluentValidation;
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
    public class ApplicationManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductService> mockProduct = new Mock<IProductService>();           
            Mock<IOrderService> mockOrder = new Mock<IOrderService>();
            Mock<ICampaignService> mockCampaign = new Mock<ICampaignService>();
            ApplicationManager appManager = new ApplicationManager(mockCampaign.Object, mockProduct.Object, mockOrder.Object);

            appManager.CreateProduct(new Product());

        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Order_validation_check()
        {
            Mock<IProductService> mockProduct = new Mock<IProductService>();
            Mock<IOrderService> mockOrder = new Mock<IOrderService>();
            Mock<ICampaignService> mockCampaign = new Mock<ICampaignService>();
            ApplicationManager appManager = new ApplicationManager(mockCampaign.Object, mockProduct.Object, mockOrder.Object);

            appManager.CreateOrder(new Order());

        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Campaign_validation_check()
        {
            Mock<IProductService> mockProduct = new Mock<IProductService>();
            Mock<IOrderService> mockOrder = new Mock<IOrderService>();
            Mock<ICampaignService> mockCampaign = new Mock<ICampaignService>();
            ApplicationManager appManager = new ApplicationManager(mockCampaign.Object, mockProduct.Object, mockOrder.Object);

            appManager.CreateCampaign(new Campaign());

        }
    }
}
