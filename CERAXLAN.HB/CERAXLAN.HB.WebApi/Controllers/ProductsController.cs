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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{productCode}", Name = "GetProduct")]
        public IActionResult GetProduct(string productCode)
        {
            return Ok(_productService.Get(productCode));
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productService.GetAll());
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {         
            return Ok(_productService.Create(product));
        }

        //[HttpDelete]
        //public IActionResult DeleteProduct(Product product)
        //{
        //    _productService.Delete(product);
        //    return NoContent();
        //}

        //[HttpPut]
        //public IActionResult UpdateProduct(Product product)
        //{
        //    return Ok(_productService.Update(product));
        //}

    }
}
