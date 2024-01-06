using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService grammerCheckService)
        {
            _gamerCheckService = grammerCheckService;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Silindi.");
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " Eklendi.");

            }
            else
            {
                throw new Exception("Böyle bir kişi bulunmamaktadır.");
            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Güncellendi.");

        }
    }
}
