namespace OlimpicDb.Entity
{
    public class OlimpicGame : IEntity
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }

        public ICollection<PlayerOlimpicGame> PlayerOlimpicGames { get; set; }
        public Place Place { get; set; }
    }
}
