using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.ConsoleApp.Commands
{
    public class GetProductInfoCommand : BaseCommand
    {
        public override string ActionMetod => "api/Products/GetProductInfo";
        public string ProductCode { get; set; }
        public GetProductInfoCommand(List<string> request)
        {
            this.Valid(request);
        }
        public override object GetRequest()
        {
            return new
            {
                ProductCode = this.ProductCode
            };
        }

        public override void Valid(List<string> request)
        {
            if (string.IsNullOrWhiteSpace(request[0]))
                throw new Exception("ProductCode is not valid");

            this.ProductCode = request[0];
        }

        public override RestType GetRestType()
        {
            return RestType.Get;
        }
    }
}
