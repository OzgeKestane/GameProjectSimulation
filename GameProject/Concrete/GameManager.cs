using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " : Silindi.");
        }

        public void Sale(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " " + campaign.CampaignName + " ile Satıldı.");

        }

        public void Save(Game game)
        {
            Console.WriteLine(game.GameName + " : Eklendi.");

        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " : Güncellendi.");

        }
    }
}
