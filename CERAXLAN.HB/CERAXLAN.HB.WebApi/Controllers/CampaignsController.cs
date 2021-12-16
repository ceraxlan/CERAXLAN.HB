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
        private readonly ICampaignService _campaignService;

        public CampaignsController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        [HttpGet("{name}", Name = "GetCampaign")]
        public IActionResult GetCampaign(string name)
        {
            return Ok(_campaignService.Get(name));
        }

        [HttpGet]
        public IActionResult GetCampaigns()
        {
            return Ok(_campaignService.GetAll());
        }

        [HttpPost]
        public IActionResult CreateCampaign(Campaign campaign)
        {
            return Ok(_campaignService.Create(campaign));
        }

        //[HttpDelete]
        //public IActionResult DeleteCampaign(Campaign campaign)
        //{
        //    _campaignService.Delete(campaign);
        //    return NoContent();
        //}

        //[HttpPut]
        //public IActionResult UpdateCampaign(Campaign campaign)
        //{
        //    return Ok(_campaignService.Update(campaign));
        //}
    }
}
