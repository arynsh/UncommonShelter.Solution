using Microsoft.EntityFrameworkCore;

namespace UncommonShelter.Models
{
  public class UncommonShelterContext : DbContext
  {
    public UncommonShelterContext(DbContextOptions<UncommonShelterContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Stephen", Species = "Sheep", Age = 5, Gender = "Male" },
              new Animal { AnimalId = 2, Name = "Roo", Species = "Donkey", Age = 6, Gender = "Male" },
              new Animal { AnimalId = 3, Name = "Molly", Species = "Donkey", Age = 8, Gender = "Female" },
              new Animal { AnimalId = 4, Name = "Walter", Species = "Camel", Age = 9, Gender = "Male" },
              new Animal { AnimalId = 5, Name = "Beatrice", Species = "Sheep", Age = 4, Gender = "Female" }
          );
    }
  }
}