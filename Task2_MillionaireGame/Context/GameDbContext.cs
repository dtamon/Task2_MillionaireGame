using Microsoft.EntityFrameworkCore;
using Task2_MillionaireGame.Domain;

namespace Task2_MillionaireGame.Context
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
