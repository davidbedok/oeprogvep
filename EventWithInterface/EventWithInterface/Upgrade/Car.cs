using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface.Upgrade
{
    public class Car : WealthItem
    {
        private string brand;

        public Car(int value, string brand)
            : base(value)
        {
            this.brand = brand;
        }

        public void accident(double percentOfDamage)
        {
            this.Value *= (1 - percentOfDamage / 100);
        }

        public override string ToString()
        {
            return "[Car] " + base.ToString() + " " + this.brand;
        }

    }
}
