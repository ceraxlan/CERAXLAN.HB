using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.ConsoleApp.Commands
{
    public class GetIncreaseTimeCommand : BaseCommand
    {
        public override string ActionMetod => "api/Campaigns/IncreaseTime";
        public uint Hour { get; set; }
        public GetIncreaseTimeCommand(List<string> request)
        {
            this.Valid(request);
        }
        public override object GetRequest()
        {
            return new
            {
                Hour = this.Hour
            };
        }

        public override void Valid(List<string> request)
        {
            if (!uint.TryParse(request[0], out uint hour))
                throw new Exception("Hour must be greater than zero");

            this.Hour = hour;
        }
    }
}
