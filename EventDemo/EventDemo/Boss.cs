using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{

    public class Boss
    {

        private readonly String name;
        
        public Boss(String name)
        {
            this.name = name;
        }

        public void init(Process process)
        {
            process.bind(new DoneHandler(this.name));

            // use delegate
            process.doneEvent += new FeaturedProgressHandler(this.occured);
        }

        public void init( Process process, DoneEvent done )
        {
            process.bind(done);

            // use delegate
            process.doneEvent += new FeaturedProgressHandler(this.occured);
        }

        public void occured(int percent, String lastAction)
        {
            Console.WriteLine("The last action was " + lastAction + " (current progress: " + percent + "%) Name of the boss: " + this.name + " (delegate FeaturedProgressHandler)");
        }

    
    }

}
