using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPEvent
{
    public interface IValueChange
    {
        void onChange(Object sender, Int32 value);
    }
}
