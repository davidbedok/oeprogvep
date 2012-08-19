using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface.Simple
{
    public class House : WealthItem
    {
        private string address;

        public House(int value, string address)
            : base(value)
        {
            this.address = address;
        }

        public void addRoom(int costOfBuilding)
        {
            this.Value += costOfBuilding;
        }

        public override string ToString()
        {
            return "[House] " + base.ToString() + " " + this.address;
        }

    }
}
