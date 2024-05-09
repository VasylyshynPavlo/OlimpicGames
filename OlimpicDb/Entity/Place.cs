namespace OlimpicDb.Entity
{
    public class Place : IEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public int OlimpicGameId { get; set; }

        public OlimpicGame OlimpicGame { get; set; }
        public Country Country { get; set; }

    }
}
