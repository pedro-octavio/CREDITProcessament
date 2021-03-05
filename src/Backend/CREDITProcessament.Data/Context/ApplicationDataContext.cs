using CREDITProcessament.Data.Configurations.Tables;
using CREDITProcessament.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CREDITProcessament.Data.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Tbl_User.Configure(modelBuilder);
            Tbl_Processament.Configure(modelBuilder);
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProcessamentModel> Processaments { get; set; }
    }
}
