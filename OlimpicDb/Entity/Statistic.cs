namespace OlimpicDb.Entity
{
    public class Statistic : IEntity
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public int Place { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistics { get; set; }
        public Sport Sport { get; set; }
    }
}
