using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public delegate void CustomEventHandler( string param );

    public class Process {

        private readonly int MINSTATE = 0;
        private readonly int MAXSTATE = 100;
        private int value = 0;
        
        public event EventHandler handler;
        public event CustomEventHandler customHandler;

        public int Status
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Process(int minstate, int maxstate )
        {
            this.MINSTATE = minstate;
            this.MAXSTATE = maxstate;
            this.Status = minstate;
        }

        public double getPercent()
        {
            return ((double)(this.Status - this.MINSTATE) / (double)(this.MAXSTATE - this.MINSTATE));
        }

        public void step( int value )
        {
            this.Status += value;
            if (this.getPercent() > 0.33)
            {
                if (this.customHandler != null) { 
                    this.customHandler(this.getPercent().ToString()); 
                }
            }
            if (this.getPercent() > 0.66)
            {                
                if (this.handler != null) { 
                    this.handler(this,EventArgs.Empty); 
                }
            }
        }        

    }
}
