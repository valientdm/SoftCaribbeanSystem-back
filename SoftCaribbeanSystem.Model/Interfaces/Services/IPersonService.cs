using SoftCaribbeanSystem.Model.Base.Response;
using SoftCaribbeanSystem.Model.Entities;

namespace SoftCaribbeanSystem.Model.Interfaces.Services
{
    public interface IPersonService
    {
        EntityResponse CreatePerson(Person request);
        EntityResponse UpdatePerson(Person request);
    }
}
