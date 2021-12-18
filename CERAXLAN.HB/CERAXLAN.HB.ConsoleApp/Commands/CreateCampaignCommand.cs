using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.ConsoleApp.Commands
{
    public class CreateCampaignCommand : BaseCommand
    {
        public override string ActionMetod => "api/Campaigns/CreateCampaign";
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public uint Duration { get; set; }
        public int PriceManipulationLimit { get; set; }
        public uint TargetSalesCount { get; set; }
        public CreateCampaignCommand(List<string> request)
        {
            this.Valid(request);
        }
        public override object GetRequest()
        {
            return new
            {
                Name = this.Name,
                ProductCode = this.ProductCode,
                Duration = this.Duration,
                PriceManipulationLimit = this.PriceManipulationLimit,
                TargetSalesCount = this.TargetSalesCount
            };
        }

        public override void Valid(List<string> request)
        {
            if (string.IsNullOrWhiteSpace(request[0]))
                throw new Exception("Name is not valid");

            if (string.IsNullOrWhiteSpace(request[1]))
                throw new Exception("ProductCode is not valid");

            if (!uint.TryParse(request[2], out uint duration))
                throw new Exception("Duration must be greater than zero");

            if (!int.TryParse(request[3], out int priceManipulationLimit))
                throw new Exception("PriceManipulationLimit must be greater than zero");

            if (!uint.TryParse(request[4], out uint targetSalesCount))
                throw new Exception("TargetSalesCount must be greater than zero");

            this.Name = request[0];
            this.ProductCode = request[1];
            this.Duration = duration;
            this.PriceManipulationLimit = priceManipulationLimit;
            this.TargetSalesCount = targetSalesCount;
        }
    }
}
