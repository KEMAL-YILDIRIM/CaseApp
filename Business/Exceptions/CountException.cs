using System;

using Business.Interfaces;

namespace Business.Exceptions
{
    public class CountException : Exception, IApplicationException
    {
        public CountException() : base()
        {
        }

        public CountException(string message) : base(message: message)
        {
        }

        public CountException(string message, Exception innerException) : base(message: message, innerException: innerException)
        {
        }
    }
}
