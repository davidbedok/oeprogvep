using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadAndWriteTextFiles
{
    public class FireWater
    {

        private const char SEPARATOR = ';';

        private readonly int unid;
        private readonly string name;
        private readonly int degree;

        public int Unid
        {
            get { return this.unid; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Degree
        {
            get { return this.degree; }
        }

        public FireWater(int unid, string name, int degree)
        {
            this.unid = unid;
            this.name = name;
            this.degree = degree;
        }

        public static FireWater parse(string value)
        {
            FireWater fireWater = null;
            if ((value != null) && ( value.Length > 0) )
            {
                string[] result = value.Split(FireWater.SEPARATOR);
                try
                {
                    int unid = Int32.Parse(result[0]);
                    string name = result[1];
                    int degree = Int32.Parse(result[2]);
                    fireWater = new FireWater(unid, name, degree);
                }
                catch (ArgumentNullException e)
                {
                    throw new BadFileFormatException(e.Message + " ("+value+")",e);
                }
                catch (FormatException e)
                {
                    throw new BadFileFormatException(e.Message + " (" + value + ")", e);
                }
                catch (OverflowException e)
                {
                    throw new BadFileFormatException(e.Message + " (" + value + ")", e);
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new BadFileFormatException(e.Message, e);
                }
            }
            return fireWater;
        }

        public override string ToString()
        {
            return this.name + " (" + this.degree + '\x00B0' + ")";
        }

    }
}
