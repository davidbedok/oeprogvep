using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface.Simple
{
    public class WealthItem : Object
    {

        private double value;
        public WealthValueOnChangeEvent handler;

        public double Value
        {
            get { return this.value; }
            protected set {
                if (this.handler != null)
                {
                    this.handler.onChange(value - this.value);
                }
                this.value = value; 
                 
            }
        }

        public WealthItem(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

    }
}
