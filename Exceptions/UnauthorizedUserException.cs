using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApi.Exceptions
{
    public class UnauthorizedUserException : Exception
    {
        public UnauthorizedUserException() { }

        public UnauthorizedUserException(string message) : base(message) { }

        public UnauthorizedUserException(string message, Exception inner) : base(message, inner) { }
    }
}