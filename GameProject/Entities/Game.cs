using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Campaign Campaign { get; set; }



    }
}
