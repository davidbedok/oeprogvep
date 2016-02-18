using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bloxorz
{
    public class InvalidMapFileException : System.ApplicationException
    {
        private readonly string fileName;

        public InvalidMapFileException(string fileName) : this(fileName, null) { }
        public InvalidMapFileException(string fileName, string message) : this(fileName, message, null) { }
        public InvalidMapFileException(string fileName, string message, System.Exception inner) : base(message, inner) {
            this.fileName = fileName;
        }

        public override string ToString()
        {
            return this.fileName + " - " + this.Message;
        }
    }
}
