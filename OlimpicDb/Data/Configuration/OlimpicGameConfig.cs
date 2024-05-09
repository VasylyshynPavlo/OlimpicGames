using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;

namespace OlimpicDb.Data.Configuration
{
    internal class OlimpicGameConfig : IEntityTypeConfiguration<OlimpicGame>
    {
        public void Configure(EntityTypeBuilder<OlimpicGame> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Place)
                .WithMany()
                .HasForeignKey(x => x.PlaceId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .Property(x => x.PlaceId).IsRequired();
        }
    }
}
