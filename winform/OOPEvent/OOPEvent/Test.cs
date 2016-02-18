using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPEvent
{
    public class Test
    {

        private Int32 value;

        private IValueChange onValueChange;
        private Object sender;

        public Test(Object sender, Int32 value)
        {
            this.sender = sender;
            this.value = value;
        }

        public Int32 Value
        {
            get { return this.value; }
            set {
                if (!value.Equals(this.value))
                {
                    this.value = value;
                    if (this.onValueChange != null)
                    {
                        this.onValueChange.onChange(this.sender, this.value);
                    }
                }
                
            }
        }

        public IValueChange OnValueChange
        {
            set { this.onValueChange = value; }
            get { return this.onValueChange; }
        }

    }
}
