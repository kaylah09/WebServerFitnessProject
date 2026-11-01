
using Microsoft.EntityFrameworkCore;
using WebServerFitnessProject.Models;

namespace WebServerFitnessProject.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
    }
}
