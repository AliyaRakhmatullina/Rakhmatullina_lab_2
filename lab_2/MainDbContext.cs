using lab_2.Entities;
using Microsoft.EntityFrameworkCore;

namespace lab_2
{
    internal class MainDbContext : DbContext
    {
        public DbSet<Bee> Bees { get; set; }
        public DbSet<Beehive> Beehives { get; set; }
        public DbSet<Apiary> Apiaries { get; set; }
        public DbSet<BeeBeehive> BeeBeehives { get; set; }
        public DbSet<BeehiveApiary> BeehivesApiaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=lab2.db");
        }
    }
}