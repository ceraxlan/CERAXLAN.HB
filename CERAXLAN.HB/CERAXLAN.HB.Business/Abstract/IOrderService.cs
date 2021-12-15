using CERAXLAN.HB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order Get(int id);
        Order Create(Order order);
        Order Update(Order order);
        void Delete(Order order);
    }
}
