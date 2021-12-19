using CERAXLAN.HB.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.ValidationRules.FluentValidation
{
    class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Product code is required.");

            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Quantity is required.");
            RuleFor(x => x.Quantity).GreaterThanOrEqualTo(1);
        }
    }
}
