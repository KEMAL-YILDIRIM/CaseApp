using System;

using Business.Interfaces;

namespace Business.Exceptions
{
    public class OperationException : Exception, IApplicationException
    {
        public OperationException() : base()
        {
        }

        public OperationException(string message) : base(message: message)
        {
        }

        public OperationException(string message, Exception innerException) : base(message: message, innerException: innerException)
        {
        }
    }
}
