using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Save(Game game);
        void Update(Game game);
        void Delete(Game game);
        void Sale(Game game, Campaign campaign);
    }
}
