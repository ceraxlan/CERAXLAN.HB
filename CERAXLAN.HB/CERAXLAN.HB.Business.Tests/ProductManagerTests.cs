using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.Business.Concrete;
using CERAXLAN.HB.DataAccess.Abstract;
using CERAXLAN.HB.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CERAXLAN.HB.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {     
        
        [TestMethod]
        public void Create_Product()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();           
            ProductManager productManager = new ProductManager(mock.Object);
            
            productManager.Create(new Product());          
        }

        
    }
}
