using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
