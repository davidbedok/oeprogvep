using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface.Simple
{
    public interface WealthValueOnChangeEvent
    {
        void onChange(double value);
    }
}
