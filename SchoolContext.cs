using Microsoft.EntityFrameworkCore;

namespace StudentDatabase
{
    // Database context for managing student records
    public class SchoolContext : DbContext
    {
        // Represents the Students table in the database
        public DbSet<Student> Students { get; set; }

        // Configure the database connection
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite to create the Student database
            optionsBuilder.UseSqlite(
                "Data Source=StudentDatabase.db");
        }
    }
}