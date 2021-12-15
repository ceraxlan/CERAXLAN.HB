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
        //private readonly ICampaignService _campaignService;

        //public CampaignsController(ICampaignService campaignService)
        //{
        //    _campaignService = campaignService;
        //}

        [HttpGet("{name}", Name = "GetCampaign")]
        public IActionResult GetCampaign(string name)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddCampaign(Campaign campaign)
        {
            //_campaignService.Add(campaign);
            return CreatedAtRoute("GetCampaign", new { name = campaign.Name }, campaign);
        }
    }
}
