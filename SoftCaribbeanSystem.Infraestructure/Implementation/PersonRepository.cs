using Microsoft.EntityFrameworkCore;
using SoftCaribbeanSystem.Infraestructure.Base.Context;
using SoftCaribbeanSystem.Infraestructure.Base.Repository;
using SoftCaribbeanSystem.Model.Entities;
using SoftCaribbeanSystem.Model.Interfaces.Repositories;

namespace SoftCaribbeanSystem.Infraestructure.Implementation
{
    public class PersonRepository: Repository<Person>,IPersonRepository
    {
        public PersonRepository(MyDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
