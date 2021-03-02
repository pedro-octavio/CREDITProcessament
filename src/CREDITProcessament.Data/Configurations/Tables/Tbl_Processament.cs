using CREDITProcessament.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CREDITProcessament.Data.Configurations.Tables
{
    internal static class Tbl_Processament
    {
        internal static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProcessamentModel>(builder =>
            {
                builder.ToTable("Tbl_Processament");

                builder.HasKey(x => x.Id);

                builder.Property(x => x.Id)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .IsRequired();

                builder.Property(x => x.UserCPF)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .IsRequired();

                builder.Property(x => x.Score)
                    .IsRequired();

                builder.Property(x => x.IsProcessed)
                    .IsRequired();

                builder.Property(x => x.LastProcessedDate)
                    .IsRequired();
            });
        }
    }
}
