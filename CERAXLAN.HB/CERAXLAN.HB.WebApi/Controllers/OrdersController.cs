using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CERAXLAN.HB.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        //[HttpGet("{id}", Name = "GetOrder")]
        //public IActionResult GetOrder(int id)
        //{
        //    return Ok(_orderService.Get(id));
        //}

        //[HttpGet]
        //public IActionResult GetOrders()
        //{
        //    return Ok(_orderService.GetAll());
        //}

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            return Ok(_orderService.Create(order));
        }

        //[HttpDelete]
        //public IActionResult DeleteOrder(Order order)
        //{
        //    _orderService.Delete(order);
        //    return NoContent();
        //}

        //[HttpPut]
        //public IActionResult UpdateOrder(Order order)
        //{
        //    return Ok(_orderService.Update(order));
        //}
    }
}
