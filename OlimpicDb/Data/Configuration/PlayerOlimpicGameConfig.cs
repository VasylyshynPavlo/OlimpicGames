using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;

namespace OlimpicDb.Data.Configuration
{
    internal class PlayerOlimpicGameConfig : IEntityTypeConfiguration<PlayerOlimpicGame>
    {
        public void Configure(EntityTypeBuilder<PlayerOlimpicGame> builder)
        {
            builder
                .HasKey(pog => new { pog.PlayerId, pog.OlimpicGameId });

            builder
                .HasOne(pog => pog.Player)
                .WithMany(p => p.PlayerOlimpicGames)
                .HasForeignKey(pog => pog.PlayerId);

            builder
                .HasOne(pog => pog.OlimpicGame)
                .WithMany(og => og.PlayerOlimpicGames)
                .HasForeignKey(pog => pog.OlimpicGameId);
        }
    }
}
