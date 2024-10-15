using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(  "yeni kampanya eklendi : " + campaign.CampaignName);
        }

        public void CampaignRemove(Campaign campaign)
        {
            Console.WriteLine(  "eski kampanya silindi : " + campaign.CampaignId);
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(  "mevcut kampanya güncellendi : " + campaign.CampaignStart);
        }
    }
}
