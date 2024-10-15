using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public float Discount { get; set; }
        public DateTime CampaignStart { get; set; }
    }
}
