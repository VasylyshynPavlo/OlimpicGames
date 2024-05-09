using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;

namespace OlimpicDb.Data.Configuration
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired();
        }
    }
}
