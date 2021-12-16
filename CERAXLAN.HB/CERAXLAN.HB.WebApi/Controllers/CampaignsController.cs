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
    public class CampaignsController : ControllerBase
    {       
        private readonly IApplicationService _applicationService;
        public CampaignsController(IApplicationService applicationService)
        {            
            _applicationService = applicationService;
        }

        [HttpGet("GetCampaignInfo/{name}")]
        public IActionResult GetCampaignInfo(string name)
        {
            return Ok(_applicationService.GetCampaignInfo(name));
        }

        [HttpGet("IncreaseTime/{value}")]
        public IActionResult IncreaseTime(uint value)
        {
            return Ok(_applicationService.IncreaseTime(value));
        }

        [HttpPost("CreateCampaign/{name},{productCode},{duration},{priceManipulationLimit},{targetSalesCount}")]
        public IActionResult CreateCampaign(string name,string productCode,uint duration,int priceManipulationLimit,uint targetSalesCount)
        {
            return Ok(_applicationService.CreateCampaign(new Campaign 
            {
                Name=name,
                ProductCode =productCode,
                Duration=duration,
                PriceManipulationLimit=priceManipulationLimit,
                TargetSalesCount=targetSalesCount
            }));
        }

      

    }
}
