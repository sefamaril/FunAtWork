using FunAtWork.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FunAtWork.Infrastructure.FunAtWorkDb
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<ContestType> ContestTypes { get; set; }
        public DbSet<Contest> Contests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contest>()
                .Property(c => c.ParticipationFee)
                .HasColumnType("decimal(18,2)");
        }
    }
}