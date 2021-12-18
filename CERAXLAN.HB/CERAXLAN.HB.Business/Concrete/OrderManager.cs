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
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
       
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
            
        }

        public Order Create(Order order)
        {        
            return _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetList();
        }

        public Order Get(int id)
        {
            return _orderDal.Get(o => o.Id == id);
        }

        public Order Update(Order order)
        {
            return _orderDal.Update(order);
        }
    }
}
