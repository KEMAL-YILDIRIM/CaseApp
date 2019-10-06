using System;

namespace Business.Exceptions
{
    public class CountExceptions : Exception, IApplicationException
    {
        public CountExceptions() : base()
        {
        }

        public CountExceptions(string message) : base(message: message)
        {
        }

        public CountExceptions(string message, Exception innerException) : base(message: message, innerException: innerException)
        {
        }
    }
}
