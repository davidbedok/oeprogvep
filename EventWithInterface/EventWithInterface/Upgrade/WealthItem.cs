using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventWithInterface.Simple;

namespace EventWithInterface.Upgrade
{
    public class WealthItem : Object
    {

        private double value;
        private List<WealthValueOnChangeEvent> handlers;

        public double Value
        {
            get { return this.value; }
            protected set
            {
                if (this.handlers != null)
                {
                    foreach (WealthValueOnChangeEvent handler in this.handlers)
                    {
                        handler.onChange(value - this.value);
                    }
                }
                this.value = value;

            }
        }

        public WealthItem(int value)
        {
            this.value = value;
        }

        public void bindHandler(WealthValueOnChangeEvent handler)
        {
            if (this.handlers == null)
            {
                this.handlers = new List<WealthValueOnChangeEvent>();
            }
            if (!this.handlers.Contains(handler))
            {
                this.handlers.Add(handler);
            }
        }

        public void unBindHandler(WealthValueOnChangeEvent handler)
        {
            if (this.handlers.Contains(handler))
            {
                this.handlers.Remove(handler);
            }
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

    }
}
