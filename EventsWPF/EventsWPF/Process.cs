using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsWPF
{
    public delegate void FeaturedProgressHandler(double progressPercent, String message);

    public class Process
    {
        private const double FIRST_FEATURED_LEVEL_PERCENT = 33;
        private const double SECOND_FEATURED_LEVEL_PERCENT = 66;

        private readonly int MINSTATE;
        private readonly int MAXSTATE;
        private int progress = 0;

        public event EventHandler commonEvent;
        public event FeaturedProgressHandler featuredProgressEvent;

        public int Progress
        {
            get { return this.progress; }
        }

        public Process(int minState, int maxState)
        {
            this.MINSTATE = minState;
            this.MAXSTATE = maxState;
            this.progress = minState;
        }

        public double getPercent()
        {
            return ((double)(this.progress - this.MINSTATE) / (double)(this.MAXSTATE - this.MINSTATE)) * 100;
        }

        public void step(int value, String user, String action)
        {
            this.progress += value;
            if (this.getPercent() > Process.FIRST_FEATURED_LEVEL_PERCENT)
            {
                if (this.featuredProgressEvent != null)
                {
                    this.featuredProgressEvent(this.getPercent(), "'" + action + "' action occured by " + user);
                }
            }
            if (this.getPercent() > Process.SECOND_FEATURED_LEVEL_PERCENT)
            {
                if (this.commonEvent != null)
                {
                    this.commonEvent(this, EventArgs.Empty);
                }
            }
        }

    }

}
