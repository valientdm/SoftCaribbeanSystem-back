using Microsoft.EntityFrameworkCore;
using SoftCaribbeanSystem.Infraestructure.Migrations.Seeds;
using SoftCaribbeanSystem.Model.Entities;

namespace SoftCaribbeanSystem.Infraestructure.Base.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PersonType> PersonType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
