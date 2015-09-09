using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{

    public delegate void FeaturedProgressHandler(int progress, String lastAtion);

    public class Process
    {

        private const int FEATURED_PROGRESS = 105;

        private int progressPercent;

        // private DoneEvent done; // single case with interface (only one bind allow)
        private List<DoneEvent> dones; // multiple case with interface (multiple binds allow)
        public FeaturedProgressHandler doneEvent; // use delegate (C# syntactic sugar) (multiple binds allow)

        public Process()
        {
            this.progressPercent = 0;
            this.dones = new List<DoneEvent>();
        }

        public void bind(DoneEvent done)
        {
            this.dones.Add(done);
        }

        public void unBind(DoneEvent done)
        {
            this.dones.Remove(done);
        }

        public void step(int valuePercent, String action)
        {
            this.progressPercent += valuePercent;
            Console.WriteLine("---=== Action: " + action + " (overall progress: " + this.progressPercent + "%) ===---");
            if (this.progressPercent >= Process.FEATURED_PROGRESS)
            {
                /*
                // single case with interface
                if (this.done != null)
                {
                    this.done.occured(this.progressPercent, action);
                }
                 */

                // multiple case with interface
                foreach (DoneEvent done in dones)
                {
                    done.occured(this.progressPercent, action);
                }

                // use delegate
                if (this.doneEvent != null)
                {
                    this.doneEvent(this.progressPercent, action);
                }
            }
        }


    }
}
