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
    public class ProductValidator : AbstractValidator<Product>
    {       
        public ProductValidator()
        {
           
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Product code is required.");
            RuleFor(x => x.ProductCode).NotEqual("").WithMessage("Product code is required.");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Price is required.");           
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stock is required.");
            
        }      
    }
}
