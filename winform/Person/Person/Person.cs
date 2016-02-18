using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonNamespace
{

  public class Person : System.Object
  {
    private string familyName;
    private string firstName;
    private int yearOfBirth;
    private bool spectacled; // szemuveges
    private SexType sexType;

    public Person(string familyName, string firstName)
    {
        this.familyName = familyName;
        this.firstName = firstName;
    }

    public string FamilyName
    {
      get { return familyName; }
      set { familyName = value; }
    }

    public string FirstName
    {
      get { return firstName; }
      set { firstName = value; }
    }

    public int YearOfBirth
    {
      get { return yearOfBirth; }
      set { yearOfBirth = value; }
    }

    public bool Spectacled
    {
      get { return spectacled; }
      set { spectacled = value; }
    }

    public SexType Sex
    {
      get { return sexType; }
      set { sexType = value; }
    }

    public override string ToString()
    {
        return this.FamilyName + " " + this.FirstName + " (" + this.YearOfBirth + ") " + (this.Spectacled ? "[Spectacled] " : "[No spectacled] ") + Sex;
    }

    public int getAge()
    {
      return System.DateTime.Now.Year - this.YearOfBirth;
    }


  }
}
