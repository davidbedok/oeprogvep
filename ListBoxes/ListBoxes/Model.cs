using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ListBoxes
{
    public class Model
    {
        private Person[] array;
        private int index;
        private ArrayList list;
        private List<Person> genericList;

        public Person[] Array
        {
            get
            {
                return this.array;
            }
        }

        public ArrayList List
        {
            get
            {
                return this.list;
            }
        }

        public List<Person> GenericList
        {
            get
            {
                return this.genericList;
            }
        }

        public Model(int size)
        {
            this.array = new Person[size];
            this.index = 0;
            this.list = new ArrayList();
            this.genericList = new List<Person>();
        }

        public void addArrayPerson(Person item)
        {
            this.array[this.index++] = item;
        }

        public void addPerson(Person item)
        {
            this.list.Add(item);
        }

        public void addGenericPerson(Person item)
        {
            this.genericList.Add(item);
        }

    }
}
