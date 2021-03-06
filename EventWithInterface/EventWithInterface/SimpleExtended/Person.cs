﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventWithInterface.Simple;

namespace EventWithInterface.SimpleExtended
{
    public class Person : Object
    {
        private const int DEF_MAX_ITEM = 10;

        private string name;
        private double wealth;
        private WealthItem[] items;
        private int itemCount;

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
                item.handler = new SimpleExtended.Person.WealthValueEventHandler(this);
                this.items[this.itemCount++] = item;
            }
        }

        public override string ToString()
        {
            return "[Person] " + this.name + " (" + this.wealth + ")";
        }

        private class WealthValueEventHandler : WealthValueOnChangeEvent
        {
            private readonly Person person;

            public WealthValueEventHandler(Person person)
            {
                this.person = person;
            }


            public void onChange(double value)
            {
                person.wealth += value; // can access outer private field
            }
        }

    }
}
