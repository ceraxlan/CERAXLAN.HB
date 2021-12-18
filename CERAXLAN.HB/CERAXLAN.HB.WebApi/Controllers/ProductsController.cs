﻿using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.Entities.Concrete;
using CERAXLAN.HB.Entities.Concrete.Requests;
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
    public class ProductsController : ControllerBase
    {      
        private readonly IApplicationService _applicationService;
        public ProductsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
   
        [HttpGet("GetProductInfo")]
        public IActionResult GetProductInfo(string productCode)
        {
            return Ok(_applicationService.GetProductInfo(productCode));
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(Product product)
        {         
            return Ok(_applicationService.CreateProduct(product));
        }      
    }
}
