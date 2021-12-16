using CERAXLAN.HB.Core.Common.Response;
using CERAXLAN.HB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(string productCode);
        Product Create(Product product);
        Product Update(Product product);
        void Delete(Product product);
        bool IsExistName(string name);
    }
}
