using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;

namespace OlimpicDb.Data.Configuration
{
    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired(false);
            builder
                .Property(x => x.Birthday)
                .IsRequired(false);
            builder
                .Property(x => x.CountryId)
                .IsRequired();
            builder
                .Property(x => x.ImageLink)
                .IsRequired(false);

            builder
                .Property(x => x.Sex)
                .IsRequired(false);
            builder
                .Property(x => x.Height)
                .IsRequired(false);
        }
    }
}
