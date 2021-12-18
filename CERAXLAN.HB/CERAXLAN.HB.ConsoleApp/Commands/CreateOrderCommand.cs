using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.ConsoleApp.Commands
{
    public class CreateOrderCommand : BaseCommand
    {
        public override string ActionMetod => "api/Orders/CreateOrder";
        public string ProductCode { get; private set; }
        public int Quantity { get; private set; }
        public CreateOrderCommand(List<string> request)
        {
            this.Valid(request);
        }
        public override object GetRequest()
        {
            return new
            {
                ProductCode = this.ProductCode,
                Quantity = this.Quantity
            };
        }

        public override void Valid(List<string> request)
        {
            if (string.IsNullOrWhiteSpace(request[0]))
                throw new Exception("ProductCode is not valid");

            if (!int.TryParse(request[1], out int quentity))
                throw new Exception("Quentity must be greater than zero");

            this.ProductCode = request[0];
            this.Quantity = quentity;
        }

        public override RestType GetRestType()
        {
            return RestType.Post;
        }
    }
}
