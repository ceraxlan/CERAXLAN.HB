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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;          
        }

        public ProductManager()
        {
        }

        //[FluentValidationAspect(typeof(ProductValidator))]
        public Product Create(Product product)
        {          
            return  _productDal.Add(product);
        }
  
        public void Delete(Product product)
        {
            _productDal.Delete(product);
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
            //_campaignService.GetCampaignWithProductCode(product.ProductCode);
            return _productDal.Update(product);
        }
        
        public bool IsExistName(string name)
        {

            return _productDal.Get(p => p.ProductCode == name)==null ? true:false;
        }
    }
}
