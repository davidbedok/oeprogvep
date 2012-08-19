using System;
using System.Collections.Generic;
using System.Text;

namespace ListBoxes
{
    public class Person
    {
        private string familyName;
        private string firstName;

        public Person(string familyName, string firstName)
        {
            this.familyName = familyName;
            this.firstName = firstName;
        }

        public override string ToString()
        {
            return this.familyName + " " + this.firstName;
        }

    }
}
