using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphWPF.Exception
{
    public class GraphParseException : ApplicationException
    {
        private String line;

        public String Line
        {
            get { return this.line; }
        }

        public GraphParseException(String message, String line, System.Exception inner)
            : base(message, inner)
        {
            this.line = line;
        }

        public override string ToString()
        {
            return Message + " Line: " + line;
        }

    }
}
