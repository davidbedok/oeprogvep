using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class DoneHandler : DoneEvent
    {

        private String nameOfTheBoss;

        public DoneHandler(String nameOfTheBoss)
        {
            this.nameOfTheBoss = nameOfTheBoss;
        }

        public void occured(int percent, String lastAction)
        {
            Console.WriteLine("The last action was " + lastAction + " (current progress: " + percent + "%) Name of the boss: " + this.nameOfTheBoss + " (class DoneHandler)");
        }

    }
}
