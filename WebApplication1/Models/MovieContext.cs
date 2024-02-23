using Microsoft.EntityFrameworkCore;

// MovieContext.cs


namespace Mission6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}