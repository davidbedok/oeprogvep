using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public interface DoneEvent
    {

        void occured( int percent, String lastAction);

    }
}
