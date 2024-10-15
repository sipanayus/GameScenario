using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal interface ICampaignService
    {
        public void CampaignAdd(Campaign campaign);
        public void CampaignRemove(Campaign campaign);
        public void CampaignUpdate(Campaign campaign);
    }
}
