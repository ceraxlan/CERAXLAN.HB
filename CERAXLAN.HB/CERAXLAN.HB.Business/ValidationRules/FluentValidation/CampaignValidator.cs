using CERAXLAN.HB.Business.Abstract;
using CERAXLAN.HB.DataAccess.Concrete.EntityFramework;
using CERAXLAN.HB.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.ValidationRules.FluentValidation
{
    class CampaignValidator : AbstractValidator<Campaign>
    {
        private ICampaignService _campaignService;
        public CampaignValidator(ICampaignService campaignService)
        {
            _campaignService = campaignService;
            
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Product code is required.");
            RuleFor(x => x.ProductCode).NotEqual("").WithMessage("Product code is required.");
            RuleFor(x => x.ProductCode).Must(_campaignService.IsExistName).WithMessage("This Product code already exists.");
        }

       
    }
}
