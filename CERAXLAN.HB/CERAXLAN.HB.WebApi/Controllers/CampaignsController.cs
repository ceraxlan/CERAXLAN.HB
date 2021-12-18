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

        [HttpGet("GetCampaignInfo")]
        public IActionResult GetCampaignInfo(string name)
        {
            return Ok(_applicationService.GetCampaignInfo(name));
        }

        [HttpGet("IncreaseTime")]
        public IActionResult IncreaseTime(int hour)
        {
            return Ok(_applicationService.IncreaseTime(hour));
        }

        [HttpPost("CreateCampaign")]
        public IActionResult CreateCampaign(Campaign campaign)
        {
            return Ok(_applicationService.CreateCampaign(campaign));
        }

      

    }
}
