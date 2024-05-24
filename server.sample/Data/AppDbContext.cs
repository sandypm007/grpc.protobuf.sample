using Microsoft.EntityFrameworkCore;

namespace Server.Sample.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("SampleDatabase");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
