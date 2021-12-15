using CERAXLAN.HB.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.ValidationRules.FluentValidation
{
    class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {           
            //RuleFor(p => p.ProductCode).NotEmpty();
            //RuleFor(p => p.Price).GreaterThan(0);
        }
    }
}
