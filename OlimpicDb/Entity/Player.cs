namespace OlimpicDb.Entity
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public int CountryId { get; set; }
        public string ImageLink { get; set; }
        public string Sex { get; set; }
        public string Height { get; set; }

        public ICollection<PlayerOlimpicGame> PlayerOlimpicGames { get; set; }
        public ICollection<PlayerStatistic> PlayerStatistic { get; set; }
        public Country Country { get; set; }
    }
}
