using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsWPF
{
    public class CustomEventArgs : EventArgs
    {

        private int custom;

        public int Custom
        {
            get { return this.custom; }
        }

        public CustomEventArgs(int custom)
        {
            this.custom = custom;
        }

    }
}
