using Microsoft.EntityFrameworkCore;
using ProjectUser.Data.Configurations;
using ProjectUser.Data.Entities;
using ProjectUser.Data.DataBaseContext;

namespace ProjectUser.Data.DataBaseContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
