using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public float DiscountRate { get; set; }
    }
}
