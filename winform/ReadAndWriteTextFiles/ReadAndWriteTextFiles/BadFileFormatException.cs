using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadAndWriteTextFiles
{
    public class BadFileFormatException : System.ApplicationException
    {
        public BadFileFormatException() : base() { }
        public BadFileFormatException(string message) : base(message) { }
        public BadFileFormatException(string message, System.Exception inner) : base(message, inner) { }
    }
}
