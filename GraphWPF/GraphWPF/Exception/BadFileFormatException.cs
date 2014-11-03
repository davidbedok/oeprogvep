using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphWPF.Exception
{
    public class BadFileFormatException : ApplicationException
    {

        public BadFileFormatException(String message) : base(message) { }
        public BadFileFormatException(String message, System.Exception inner) : base(message, inner) { }

        public override string ToString()
        {
            return this.Message + this.GetBaseException();
        }

    }
}
