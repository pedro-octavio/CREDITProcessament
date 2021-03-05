using CREDITProcessament.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CREDITProcessament.Data.Configurations.Tables
{
    internal static class Tbl_User
    {
        internal static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>(builder =>
            {
                builder.ToTable("Tbl_User");

                builder.HasKey(x => x.CPF);

                builder.Property(x => x.CPF)
                    .HasMaxLength(11)
                    .IsFixedLength()
                    .IsRequired();

                builder.Property(x => x.Name)
                    .HasMaxLength(120)
                    .IsRequired();

                builder.HasOne<ProcessamentModel>()
                    .WithOne()
                    .HasForeignKey<ProcessamentModel>(x => x.UserCPF)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
