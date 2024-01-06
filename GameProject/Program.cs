using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

Gamer gamer = new Gamer()
{
    Id = 1,
    FirstName = "Özge",
    LastName = "Kestane",
    DateOfBirth = new DateTime(1997, 07, 11),
    NationalityId = "123456"
};
GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
gamerManager.Save(gamer);
gamerManager.Update(gamer);
gamerManager.Delete(gamer);



Game game = new Game();
game.Id = 1;
game.GameName = "League of Legends";
game.Description = "Moba";
game.Price = 1500;

GameManager gameManager = new GameManager();
gameManager.Save(game);



Campaign campaign = new Campaign();
campaign.Id = 1;
campaign.CampaignName = "Yeni Yıl İndirimi";
campaign.DiscountRate = 30;

CampaignManager campaignManager = new CampaignManager();
campaignManager.Save(campaign);
campaignManager.Update(campaign);

gameManager.Sale(game, campaign);


Console.ReadLine();

