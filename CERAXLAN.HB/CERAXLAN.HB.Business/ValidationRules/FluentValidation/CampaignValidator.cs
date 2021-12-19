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
        
        public CampaignValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Campaign Name is required.");
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Product code is required.");

            RuleFor(x => x.Duration).NotEmpty().WithMessage("Duration is required.");
            RuleFor(x => x.Duration).GreaterThanOrEqualTo(1);

            RuleFor(x => x.PriceManipulationLimit).NotEmpty().WithMessage("PriceManipulationLimit is required.");
            RuleFor(x => x.PriceManipulationLimit).GreaterThanOrEqualTo(1);

            RuleFor(x => x.TargetSalesCount).NotEmpty().WithMessage("TargetSalesCount is required.");
            RuleFor(x => x.TargetSalesCount).GreaterThanOrEqualTo(1);
        }

       
    }
}
