using Microsoft.EntityFrameworkCore;
using play_360.EF.Models;
using System.Reflection;

namespace play_360.EF.Contexts
{
    public class Play360Context : DbContext
    {
        public DbSet<User> Users {  get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<UserAchievement> UserAchievement { get; set; }

        public Play360Context(DbContextOptions<Play360Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
