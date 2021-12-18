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
        private readonly IApplicationService _applicationService;
        public OrdersController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
      
        [HttpPost("CreateOrder")]
        public IActionResult CreateOrder(Order order)
        {
            return Ok(_applicationService.CreateOrder(order));
        }      
    }
}
