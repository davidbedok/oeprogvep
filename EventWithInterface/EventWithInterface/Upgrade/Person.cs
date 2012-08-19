using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface.Upgrade
{
    public class Person : Object
    {
        private const int DEF_MAX_ITEM = 10;

        private string name;
        private double wealth;
        private WealthItem[] items;
        private int itemCount;

        public double Wealth
        {
            get { return this.wealth; }
            set { this.wealth = value; }
        }

        public Person(string name, int maxItem)
        {
            this.name = name;
            if (maxItem < 1)
            {
                maxItem = Person.DEF_MAX_ITEM;
            }
            this.items = new WealthItem[maxItem];
        }

        public void addItem(WealthItem item)
        {
            if (item != null)
            {
                this.wealth += item.Value;
                item.bindHandler(new WealthValueEventHandler(this));
                this.items[this.itemCount++] = item;
            }
        }

        public override string ToString()
        {
            return "[Person] " + this.name + " (" + this.wealth + ")";
        }

    }
}
