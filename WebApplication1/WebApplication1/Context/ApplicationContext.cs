using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Titles> TitlesEnumerable { get; set; }
        public DbSet<Items> ItemsEnumerable { get; set; }
        public DbSet<Characters> CharactersEnumerable { get; set; }
        public DbSet<Character_Titles> CharacterTitlesEnumerable { get; set; }
        public DbSet<Backpacks> BackpacksEnumerable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Titles>().HasData(
                new Titles { Id = 1, Name = "Title 1" },
                new Titles { Id = 2, Name = "Title 2" }
            );

            modelBuilder.Entity<Items>().HasData(
                new Items { Id = 1, Name = "Item 1", Weight = 5 },
                new Items { Id = 2, Name = "Item 2", Weight = 3 },
                new Items { Id = 3, Name = "Item 3", Weight = 5 },
                new Items { Id = 4, Name = "Item 4", Weight = 3 }
            );

            modelBuilder.Entity<Characters>().HasData(
                new Characters { Id = 1, FirstName = "John", LastName = "Doe", CurrentWei = 10, MaxWeight = 20 },
                new Characters { Id = 2, FirstName = "Jane", LastName = "Smith", CurrentWei = 15, MaxWeight = 25 }
            );

            modelBuilder.Entity<Character_Titles>().HasData(
                new Character_Titles { CharacterId = 1, TitleId = 1, AcquiredAt = DateTime.UtcNow },
                new Character_Titles { CharacterId = 2, TitleId = 2, AcquiredAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Backpacks>().HasData(
                new Backpacks { CharacterId = 1, ItemId = 1, Amount = 2 },
                new Backpacks { CharacterId = 2, ItemId = 2, Amount = 1 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}