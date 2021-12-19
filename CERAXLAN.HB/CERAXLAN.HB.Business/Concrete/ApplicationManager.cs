using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.Business.ValidationRules.FluentValidation;
using CERAXLAN.HB.Core.Aspects.Postsharp.ValidationAspects;
using CERAXLAN.HB.Core.Common.Response;
using CERAXLAN.HB.Core.CrossCuttingConcerns.Validations.FluentValidation;
using CERAXLAN.HB.Entities.Concrete;
using CERAXLAN.HB.Entities.Concrete.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Concrete
{
    public class ApplicationManager : IApplicationService
    {
        private readonly ICampaignService _campaignService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        public ApplicationManager(ICampaignService campaignService, IProductService productService, IOrderService orderService)
        {
            _campaignService = campaignService;
            _productService = productService;
            _orderService = orderService;
        }

        public int GetTime()
        {
            return Application.Hour;
        }

        public ResultMessage IncreaseTime(int value)
        {
            if (value == 0) { Application.Hour = 0; } else { Application.Hour += value; }
            
            CheckCampaigns();
            return new ResultMessage { Message = "Time is " + GetTime() + ":00" };
        }

        public void CheckCampaigns()
        {
            var campaignList = _campaignService.GetAll();
            foreach (var campaign in campaignList)
            {
                var result = _campaignService.IsActiveCampaign(campaign.Name);
                if (result)
                {
                    var product = _productService.Get(campaign.ProductCode);
                    Random r = new Random();
                    var percentage = (int)r.Next(1, campaign.PriceManipulationLimit);
                    var discount = (int)(product.Price * percentage) / 100;
                    if (product.Price > discount)
                    {
                        product.Price -= discount;
                        
                        _productService.Update(product);
                    }
                }
                else
                {
                    campaign.Status = "Ended !";
                    campaign.Turnover = campaign.TargetSalesCount - campaign.TotalSales;
                    _campaignService.Update(campaign);
                    var product = _productService.Get(campaign.ProductCode);
                    product.Price = product.FirstPrice;
                    
                    _productService.Update(product);
                }
            }
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public ResultMessage CreateProduct(Product product)
        {
            
            var _product = _productService.Get(product.ProductCode);
            if (_product != null) 
            {
                product.FirstPrice = product.Price;
                var updatedProduct = _productService.Update(product);
                return new ResultMessage
                {
                    Message = "This product is available and has now been updated !",
                    Result = new ProductView
                    {
                        ProductCode = updatedProduct.ProductCode,
                        Price = updatedProduct.Price,
                        Stock = updatedProduct.Stock
                    }
                };
            }
            

            var productBase = _productService.Create(product);
            return new ResultMessage { Message = "Product created ", Result = new ProductView
            {   
                 ProductCode= productBase.ProductCode,
                 Price= productBase.Price,
                 Stock= productBase.Stock
            }};
        }

        
        public ResultMessage GetProductInfo(string productCode)
        {
            var productBase = _productService.Get(productCode);
            if(productBase==null) return new ResultMessage { Message = "No such product found !" };

            return new ResultMessage { Message = "Product Info ", Result = new ProductView 
            {
                ProductCode = productBase.ProductCode,
                Price = productBase.Price,
                Stock = productBase.Stock
            }};
        }

        [FluentValidationAspect(typeof(OrderValidator))]
        public ResultMessage CreateOrder(Order order)
        {
            var product = _productService.Get(order.ProductCode);
            if (product.Stock >= order.Quantity)
            {
                if (product.Price != product.FirstPrice)//there is a discount
                {
                    
                    var campaign = _campaignService.GetCampaignWithProductCode(product.ProductCode);
                    var limit = campaign.TargetSalesCount - campaign.TotalSales;
                    if (order.Quantity > limit)
                    {
                        return new ResultMessage { Message = "Please order "+limit+" items to take advantage of the discount! " };
                    }

                    campaign.TotalSales += order.Quantity;
                    campaign.TotalPayment += order.Quantity * product.Price; 
                    _campaignService.Update(campaign);
                    CheckCampaigns();
                }

                product.Stock = product.Stock - order.Quantity;
                _productService.Update(product);

                var orderBase = _orderService.Create(order);             
                return new ResultMessage { Message = "Order created ", Result = new OrderView 
                {
                    ProductCode= orderBase.ProductCode,
                    Quantity= orderBase.Quantity
                }};
            }
            else
            {
                return new ResultMessage { Message = "Order could not be created! Insufficient product! " };
            }
        }

        [FluentValidationAspect(typeof(CampaignValidator))]
        public ResultMessage CreateCampaign(Campaign campaign)
        {
            var _campaign = _campaignService.Get(campaign.Name);
            if (_campaign != null) 
            {
                
                var updatedCampaign = _campaignService.Update(campaign);
                CheckCampaigns();
                return new ResultMessage { Message = "This campaign is available and has now been updated !",
                    Result = new CampaignView
                    {
                        Name = updatedCampaign.Name,
                        ProductCode = updatedCampaign.ProductCode,
                        Duration = updatedCampaign.Duration,
                        PriceManipulationLimit = updatedCampaign.PriceManipulationLimit,
                        TargetSalesCount = updatedCampaign.TargetSalesCount
                    }
                };
            }
                

            var campaignBase = _campaignService.Create(campaign);
            CheckCampaigns();
            return new ResultMessage { Message = "Campaign created ", Result = new CampaignView 
            {
                Name = campaignBase.Name,
                ProductCode =campaignBase.ProductCode,
                Duration=campaignBase.Duration,
                PriceManipulationLimit=campaignBase.PriceManipulationLimit,
                TargetSalesCount=campaignBase.TargetSalesCount
            }};
        }

        public ResultMessage GetCampaignInfo(string name)
        {
            var campaignBase = _campaignService.Get(name);
            if (campaignBase == null) return new ResultMessage { Message = "No such campaign found !" };

            return new ResultMessage { Message = "Campaign Info ", Result = new CampaignInfoView 
            {
                Name = campaignBase.Name,
                Status = campaignBase.Status,
                TargetSales = campaignBase.TargetSalesCount,
                TotalSales = campaignBase.TotalSales,
                Turnover = campaignBase.Turnover,
                AverageItemPrice= campaignBase.TotalSales == 0 ? 0 : campaignBase.TotalPayment / campaignBase.TotalSales
            }};
        }
    }
}
