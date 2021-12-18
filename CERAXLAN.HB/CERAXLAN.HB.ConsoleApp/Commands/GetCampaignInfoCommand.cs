using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.ConsoleApp.Commands
{
    public class GetCampaignInfoCommand : BaseCommand
    {
        public override string ActionMetod => "api/Campaigns/GetCampanignInfo";
        public string Name { get; set; }
        public GetCampaignInfoCommand(List<string> request)
        {
            this.Valid(request);
        }
        public override object GetRequest()
        {
            return new
            {
                Name = this.Name
            };
        }

        public override void Valid(List<string> request)
        {
            if (string.IsNullOrWhiteSpace(request[0]))
                throw new Exception("Name is not valid");

            this.Name = request[0];
        }
    }
}
