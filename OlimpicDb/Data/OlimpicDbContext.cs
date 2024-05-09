using Microsoft.EntityFrameworkCore;
using OlimpicDb.Entity;

namespace OlimpicDb.Data
{
    public class OlimpicDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string strcon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam_OlimpicGames_Vasylyshyn;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(strcon);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OlimpicDbContext).Assembly);
            DbInitializer.SetDefaultdata(modelBuilder);


            //string json = File.ReadAllText("Players.json");
            //List<Player> players = JsonConvert.DeserializeObject<List<Player>>(json);
            //if (players != null || players.Count > 0)
            //{
            //    foreach (Player player in players)
            //    {
            //        Players.Add(player);
            //    }
            //}
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<OlimpicGame> OlimpicGames { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerOlimpicGame> PlayerOlimpicGames { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
    }
}
