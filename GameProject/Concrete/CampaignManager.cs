using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : Silindi.");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : Eklendi.");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : Güncellendi.");

        }
    }
}
