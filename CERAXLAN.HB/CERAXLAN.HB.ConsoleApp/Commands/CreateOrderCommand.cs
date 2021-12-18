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
        public uint Quentity { get; private set; }
        public CreateOrderCommand(List<string> request)
        {
            this.Valid(request);
        }
        public override object GetRequest()
        {
            return new
            {
                ProductCode = this.ProductCode,
                Quentity = this.Quentity
            };
        }

        public override void Valid(List<string> request)
        {
            if (string.IsNullOrWhiteSpace(request[0]))
                throw new Exception("ProductCode is not valid");

            if (!uint.TryParse(request[1], out uint quentity))
                throw new Exception("Quentity must be greater than zero");

            this.ProductCode = request[0];
            this.Quentity = quentity;
        }
    }
}
