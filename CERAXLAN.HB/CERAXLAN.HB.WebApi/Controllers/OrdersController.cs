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
        [HttpGet("{productCode}", Name = "GetOrder")]
        public IActionResult GetOrder(string productCode)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            return CreatedAtRoute("GetOrder", new { productCode = order.ProductCode }, order);
        }
    }
}
