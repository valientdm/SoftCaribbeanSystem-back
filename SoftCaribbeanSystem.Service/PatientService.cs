using SoftCaribbeanSystem.Common.Exceptions;
using SoftCaribbeanSystem.Model.Base.Response;
using SoftCaribbeanSystem.Model.Interfaces.Repositories;
using SoftCaribbeanSystem.Model.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaribbeanSystem.Service
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public EntityResponse GetPatientsRegistered()
        {
            EntityResponse response;
            try
            {
                var patients = _patientRepository.FindAll().ToList();

                response = new EntityResponse
                {
                    Success = new SuccessResponse
                    {
                        Entity = patients,
                        Message = this.GetType().Name,
                        StatusCode = System.Net.HttpStatusCode.OK
                    }
                };
            }
            catch (EntityException ex)
            {
                response = new EntityResponse
                {
                    Errors = new List<Error>
                    {
                        new Error
                        {
                            Message = $"An exception ocurred trying to get all patients: {ex.Message}",
                            StatusCode = System.Net.HttpStatusCode.InternalServerError
                        }
                    }
                };
            }


            return response;
        }
    }
}
