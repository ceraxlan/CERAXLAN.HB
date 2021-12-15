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
    public class ProductsController : ControllerBase
    {
        //private readonly IProductService _productService;

        //public ProductsController(IProductService productService)
        //{
        //    _productService = productService;
        //}

        [HttpGet("{productCode}", Name = "GetProduct")]
        public IActionResult GetProduct(string productCode)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            //_productService.Add(product);
            return CreatedAtRoute("GetProduct", new { productCode = product.ProductCode }, product);
        }

    }
}
