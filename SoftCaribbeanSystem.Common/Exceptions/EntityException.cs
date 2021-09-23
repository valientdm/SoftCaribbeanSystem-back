using System;
namespace SoftCaribbeanSystem.Common.Exceptions
{
    public class EntityException: Exception
    {
        public EntityException()
        {
        }

        public EntityException(string message): base(message)
        {
        }

        public EntityException(string message, Exception inner)
            :base(message, inner)
        {
        }
    }
}
