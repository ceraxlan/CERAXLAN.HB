using Autofac;
using CERAXLAN.HB.Business.ValidationRules.FluentValidation;
using CERAXLAN.HB.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.DependencyResolvers.AutoFac
{
    public class ValidationModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductValidator>().As<IValidator<Product>>().SingleInstance();
            builder.RegisterType<OrderValidator>().As<IValidator<Order>>().SingleInstance();
            builder.RegisterType<CampaignValidator>().As<IValidator<Campaign>>().SingleInstance();
        }
    }
}
