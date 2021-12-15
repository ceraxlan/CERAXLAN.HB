using CERAXLAN.HB.Core.DataAccess;
using CERAXLAN.HB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.DataAccess.Abstract
{
    public interface ICampaignDal : IEntityRepository<Campaign>
    {
    }
}
