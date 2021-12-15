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
            //
        }
    }
}
