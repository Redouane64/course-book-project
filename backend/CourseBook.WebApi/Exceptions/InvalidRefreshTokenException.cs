namespace CourseBook.WebApi.Exceptions
{
    using System;

    public class InvalidRefreshTokenException : Exception
    {
        public InvalidRefreshTokenException(string message)
            : base(message)
        { }
    }
}
