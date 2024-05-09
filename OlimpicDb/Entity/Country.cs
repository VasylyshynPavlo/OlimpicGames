namespace OlimpicDb.Entity
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? CountryFlagLink { get; set; }
    }
}
