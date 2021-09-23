using SoftCaribbeanSystem.Common.Exceptions;
using SoftCaribbeanSystem.Model.Base.Response;
using SoftCaribbeanSystem.Model.Entities;
using SoftCaribbeanSystem.Model.Interfaces.Repositories;
using SoftCaribbeanSystem.Model.Interfaces.Services;

namespace SoftCaribbeanSystem.Service
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public EntityResponse CreatePerson(Person request)
        {
            EntityResponse response;

            try
            {
                _personRepository.Add(request);

                response = new EntityResponse
                {
                    Success = new SuccessResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.Created,
                        Message = "Person created successfully"
                    }
                };
            }
            catch (EntityException ex)
            {
                response = new EntityResponse
                {
                    Errors = new System.Collections.Generic.List<Error>
                    {
                        new Error
                        {
                            Message = $"An error ocurred trying to create a person: {ex.Message}",
                            StatusCode = System.Net.HttpStatusCode.InternalServerError
                        }
                    }
                };
            }

            return response;
        }

        public EntityResponse UpdatePerson(Person request)
        {
            EntityResponse response;

            try
            {
                var person = _personRepository.FindById(request.Id);

                if (person == null)
                {
                    response = new EntityResponse
                    {
                        Errors = new System.Collections.Generic.List<Error>
                    {
                        new Error
                        {
                            Message = $"Person not found",
                            StatusCode = System.Net.HttpStatusCode.NotFound
                        }
                    }
                    };
                }

                _personRepository.Update(request);

                response = new EntityResponse
                {
                    Success = new SuccessResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Message = "Person updated successfully"
                    }
                };
            }
            catch (EntityException ex)
            {
                response = new EntityResponse
                {
                    Errors = new System.Collections.Generic.List<Error>
                    {
                        new Error
                        {
                            Message = $"An error ocurred trying to update a person: {ex.Message}",
                            StatusCode = System.Net.HttpStatusCode.InternalServerError
                        }
                    }
                };
            }

            return response;
        }
    }
}
