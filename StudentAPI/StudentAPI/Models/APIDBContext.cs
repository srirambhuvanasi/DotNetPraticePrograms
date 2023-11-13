using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class APIDBContext:DbContext
    {
        public APIDBContext(DbContextOptions options):base (options)
        {

        }
        public DbSet<Student>students { get; set; }
    }
}
