using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;

namespace OlimpicDb.Data.Configuration
{
    public class SportConfig : IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired();
            builder
                .Property(x => x.Description)
                .IsRequired(false)
                .HasDefaultValue("");
        }
    }
}
