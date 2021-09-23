using System.Collections.Generic;

namespace SoftCaribbeanSystem.Model.Base.Response
{
    public class EntityResponse
    {
        public EntityResponse()
        {
            Errors = new List<Error>();
        }
        public SuccessResponse Success { get; set; }
        public List<Error> Errors { get; set; }
    }
}
