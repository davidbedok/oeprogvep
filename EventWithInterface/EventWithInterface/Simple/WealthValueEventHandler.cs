using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface.Simple
{
    public class WealthValueEventHandler : WealthValueOnChangeEvent
    {

        private readonly Person person;

        public WealthValueEventHandler(Person person)
        {
            this.person = person;
        }


        public void onChange(double value)
        {
            person.Wealth += value;
        }
    }
}
