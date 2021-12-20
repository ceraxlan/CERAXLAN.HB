using CERAXLAN.HB.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CERAXLAN.HB.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p => p.ProductCode.Contains("P"));

            Assert.IsTrue(result.Count>0);

        }
    }
}
