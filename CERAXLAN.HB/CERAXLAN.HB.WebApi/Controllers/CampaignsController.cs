using CERAXLAN.HB.Business.Abstract;
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
    public class CampaignsController : ControllerBase
    {       
        private readonly IApplicationService _applicationService;
        public CampaignsController(IApplicationService applicationService)
        {            
            _applicationService = applicationService;
        }

        [HttpPost("GetCampaignInfo")]
        public IActionResult GetCampaignInfo(GetCampaignInfoRequest request)
        {
            return Ok(_applicationService.GetCampaignInfo(request.Name));
        }

        [HttpPost("IncreaseTime")]
        public IActionResult IncreaseTime(GetIncreaseTimeRequest request)
        {
            return Ok(_applicationService.IncreaseTime(request.Hour));
        }

        [HttpPost("CreateCampaign")]
        public IActionResult CreateCampaign(CreateCampaignRequest request)
        {
            return Ok(_applicationService.CreateCampaign(new Campaign {Name=request.Name,ProductCode=request.ProductCode,Duration=request.Duration,PriceManipulationLimit=request.PriceManipulationLimit, TargetSalesCount=request.TargetSalesCount }));
        }

      

    }
}
