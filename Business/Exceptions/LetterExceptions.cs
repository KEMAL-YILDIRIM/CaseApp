using System;

namespace Business.Exceptions
{
    public class LetterExceptions : Exception, IApplicationException
    {
        public LetterExceptions() : base()
        {
        }

        public LetterExceptions(string message) : base(message: message)
        {
        }

        public LetterExceptions(string message, Exception innerException) : base(message: message, innerException: innerException)
        {
        }
    }
}
