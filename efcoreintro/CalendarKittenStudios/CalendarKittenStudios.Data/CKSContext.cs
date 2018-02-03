using Microsoft.EntityFrameworkCore;
using CalendarKittenStudios.Domain;

namespace CalendarKittenStudios.Data
{
    public class CKSContext: DbContext
    {
        public DbSet<Calendar> Calenders { get; set; }
        public DbSet<Kitten> Kittens { get; set; }
        public DbSet<Photographer> Photographers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=cks0;Integrated Security=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelingEngagement>()
                .HasKey(e => new { e.KittenID, e.CalendarPageID });
            base.OnModelCreating(modelBuilder);
        }
    }
}
