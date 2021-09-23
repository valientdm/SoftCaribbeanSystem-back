using Microsoft.EntityFrameworkCore;
using SoftCaribbeanSystem.Model.Entities;

namespace SoftCaribbeanSystem.Infraestructure.Migrations.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonType>().HasData(

                new PersonType
                {
                    Id = 1,
                    Name = "Employee"
                },
                 new PersonType
                 {
                     Id = 2,
                     Name = "Patient"
                 },
                  new PersonType
                  {
                      Id = 3,
                      Name = "Worker"
                  }
                );
        }
    }
}
