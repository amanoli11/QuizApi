using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApi.Exceptions
{
    public class DataNotFoundException : Exception
    {
        public DataNotFoundException() { }

        public DataNotFoundException(string message) : base(message) { }

        public DataNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}