using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bloxorz
{
    public class InvalidArgumentException : System.ApplicationException
    {
        
        public InvalidArgumentException() : base() { }
        public InvalidArgumentException(string message) : base(message) { }
        public InvalidArgumentException(string message, System.Exception inner)
            : base(message, inner) { }

    }
}
