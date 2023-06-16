using Microsoft.EntityFrameworkCore;
using QuizApi.Data.Models;

namespace QuizApi.Data.DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { 

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
