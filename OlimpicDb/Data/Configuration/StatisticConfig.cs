using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;
using System.Reflection.Emit;

namespace OlimpicDb.Data.Configuration
{
    public class StatisticConfig : IEntityTypeConfiguration<Statistic>
    {
        public void Configure(EntityTypeBuilder<Statistic> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
               .HasOne(x => x.Sport)
               .WithMany()
               .HasForeignKey(x => x.SportId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            builder
               .Property(x => x.SportId).IsRequired();
            builder
                .HasOne(s => s.Sport)
                .WithMany()
                .HasForeignKey(s => s.SportId);
        }
    }
}
