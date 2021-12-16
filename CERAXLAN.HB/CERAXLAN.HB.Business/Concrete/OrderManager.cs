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
        private IProductService _prouctService;
        private ICampaignService _campaignService;
        public OrderManager(IOrderDal orderDal,IProductService prouctService, ICampaignService campaignService)
        {
            _orderDal = orderDal;
            _prouctService = prouctService;
            _campaignService = campaignService;

        }

        [FluentValidationAspect(typeof(OrderValidator))]
        public ResultMessage Create(Order order)
        {
            var product = _prouctService.Get(order.ProductCode);
            if (product.Stock >= order.Quantity) 
            {
                var campaign = _campaignService.GetCampaignWithProductCode(product.ProductCode);
                var resultActive = _campaignService.IsActiveCampaign(campaign.Name);
                if (resultActive)
                {
                    //indirim uygulat
                }
                else
                {
                    //normal fiyattan sat
                }

                product.Stock = product.Stock-order.Quantity;
                _prouctService.Update(product);
                return new ResultMessage { Message = "Order created ", Result = _orderDal.Add(order) };
            } 
            else
            {
                return new ResultMessage { Message = "Order could not be created! Insufficient product! " };
            }
            
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
