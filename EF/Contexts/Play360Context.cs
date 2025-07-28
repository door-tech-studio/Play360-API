using Microsoft.EntityFrameworkCore;
using play_360.EF.Models;
using System.Reflection;

namespace play_360.EF.Contexts
{
    public class Play360Context : DbContext
    {
        public DbSet<User> Users {  get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserAchievement> Achievements { get; set; }
        public DbSet<WellnessMultipleChoiceQuestion> WellnessMultipleChoiceQuestion { get; set; }
        public DbSet<WellnessMultipleChoiceAnswer> WellnessMultipleChoiceAnswer { get; set; }
        public DbSet<WellnessScaleQuestion> WellnessScaleQuestion { get; set; }
        public DbSet<WellnessScaleQuestionAnswer> WellnessScaleQuestionAnswer { get; set; }
        public DbSet<WellnessBooleanQuestion> WellnessBooleanQuestion { get; set; }
        public DbSet<WellnessBooleanQuestionAnswer> WellnessBooleanQuestionAnswer { get; set; }
        public DbSet<WellnessMultipleChoiceCheckinResponse> WellnessMultipleChoiceCheckinResponse { get; set; }
        public DbSet<WellnessCheckin> WellnessCheckin { get; set; }
        public DbSet<WellnessScaleQuestionCheckinResponse> WellnessScaleQuestionCheckinResponse { get; set; }
        public DbSet<WellnessBooleanQuestionCheckinResponse> WellnessBooleanQuestionCheckinResponse { get; set; }

        public Play360Context(DbContextOptions<Play360Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
