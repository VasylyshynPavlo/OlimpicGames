using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimpicDb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicDb.Data.Configuration
{
    internal class PlayerStatisticConfig : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {
            builder.
                HasKey(ogs => new { ogs.PlayerId, ogs.StatisticId });

            builder
                .HasOne(ogs => ogs.Player)
                .WithMany(og => og.PlayerStatistic)
                .HasForeignKey(ogs => ogs.PlayerId);

            builder
                .HasOne(ogs => ogs.Statistic)
                .WithMany(s => s.PlayerStatistics)
                .HasForeignKey(ogs => ogs.StatisticId);
        }
    }
}
