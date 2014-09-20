using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class BossDoneHandler : DoneEvent
    {

        public void occured(int percent, String lastAction)
        {
            Console.WriteLine("Report of the boss of the boss! The last action was " + lastAction + " (current progress: "+percent +"%) (class BossDoneHandler)");
        }

    }
}
