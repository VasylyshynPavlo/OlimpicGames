using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;

namespace OlimpicDb.Data.Configuration
{
    public class PlaceConfig : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder
                .HasOne(p => p.OlimpicGame)
                .WithOne(o => o.Place)
                .HasForeignKey<OlimpicGame>(o => o.PlaceId);

            builder
                .Property(x => x.Date)
                .IsRequired();

            builder
                .Property(x => x.City)
                .IsRequired();
        }
    }
}
