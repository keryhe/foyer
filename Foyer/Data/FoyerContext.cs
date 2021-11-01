using Microsoft.EntityFrameworkCore;
using Foyer.Data.Models;

namespace Foyer.Data
{
    public class FoyerContext: DbContext
    {
        public FoyerContext(DbContextOptions<FoyerContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tile> Tiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Tile>().ToTable("Tile");
        }
    }
}
