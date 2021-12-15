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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Create(Product product)
        {                 
            return _productDal.Add(product);
        }
  
        public void Delete(Product Product)
        {
            _productDal.Delete(Product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }  

        public Product Get(string productCode)
        {
            return _productDal.Get(p => p.ProductCode == productCode);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
