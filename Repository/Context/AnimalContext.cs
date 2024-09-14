using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class AnimalContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }


        public AnimalContext(DbContextOptions<AnimalContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Animal>()
                .HasKey(a => a.Id);
            modelBuilder.Entity<Animal>()
               .Property(a => a.Id)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Animal>()
                .Property(a => a.Especie)
                .IsRequired()
                .HasMaxLength(200);
            modelBuilder.Entity<Animal>()
             .Property(a => a.Raca)
             .HasMaxLength(100);
        }
    }
}
