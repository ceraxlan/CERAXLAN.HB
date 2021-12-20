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
    public class OrderManagerTests
    {
        [TestMethod]
        public void Create_Order()
        {
            Mock<IOrderDal> mock = new Mock<IOrderDal>();
            OrderManager orderManager = new OrderManager(mock.Object);

            orderManager.Create(new Order());
        }
    }
}
