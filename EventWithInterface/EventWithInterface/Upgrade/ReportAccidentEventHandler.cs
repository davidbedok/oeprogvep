using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventWithInterface.Simple;

namespace EventWithInterface.Upgrade
{
    public class ReportAccidentEventHandler : WealthValueOnChangeEvent
    {

        public void onChange(double value)
        {
            System.Console.WriteLine("Car accident! Damage: " + value);
        }

    }
}
