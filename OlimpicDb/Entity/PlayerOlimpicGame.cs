namespace OlimpicDb.Entity
{
    public class PlayerOlimpicGame
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int OlimpicGameId { get; set; }
        public OlimpicGame OlimpicGame { get; set; }
    }
}
