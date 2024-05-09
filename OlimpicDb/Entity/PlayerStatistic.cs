namespace OlimpicDb.Entity
{
    public class PlayerStatistic
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int StatisticId { get; set; }
        public Statistic Statistic { get; set; }
    }
}
