using CERAXLAN.HB.Core.Common.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.Business.Abstract
{
    public interface IAppTimeService
    {
        uint GetTime();
        ResultMessage IncreaseTime(uint value);
    }
}
