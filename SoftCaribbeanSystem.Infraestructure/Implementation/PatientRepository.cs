using SoftCaribbeanSystem.Infraestructure.Base.Context;
using SoftCaribbeanSystem.Infraestructure.Base.Repository;
using SoftCaribbeanSystem.Model.Entities;
using SoftCaribbeanSystem.Model.Interfaces.Repositories;

namespace SoftCaribbeanSystem.Infraestructure.Implementation
{
    public class PatientRepository: Repository<Patient>, IPatientRepository
    {
        public PatientRepository(MyDbContext myDbContext): base(myDbContext)
        {

        }
    }
}
