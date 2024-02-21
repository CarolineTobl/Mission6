using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)  //constructor
        {
        } //creating a class of time MovieContext

        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
