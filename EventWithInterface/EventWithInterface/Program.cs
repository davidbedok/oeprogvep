using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface
{
    public class Program : Object
    {

        private static void testSimple(){
            Simple.Car iCar = new Simple.Car(2000, "Rover");
            Simple.House iHouse = new Simple.House(13000, "Becsi ut 103.");

            Simple.Person iPerson = new Simple.Person("Teszt Elek", 10);
            System.Console.WriteLine(iPerson);
            iPerson.addItem(iCar);
            iPerson.addItem(iHouse);
            System.Console.WriteLine(iPerson);

            iCar.accident(20);
            System.Console.WriteLine(iPerson);
            iHouse.addRoom(1500);
            System.Console.WriteLine(iPerson);
        }

        private static void testSimpleExtended()
        {
            Simple.Car iCar = new Simple.Car(2000, "Rover");
            Simple.House iHouse = new Simple.House(13000, "Becsi ut 103.");

            SimpleExtended.Person iPerson = new SimpleExtended.Person("Teszt Elek", 10);
            System.Console.WriteLine(iPerson);
            iPerson.addItem(iCar);
            iPerson.addItem(iHouse);
            System.Console.WriteLine(iPerson);

            iCar.accident(20);
            System.Console.WriteLine(iPerson);
            iHouse.addRoom(1500);
            System.Console.WriteLine(iPerson);
        }

        private static void testUpgrade()
        {
            Upgrade.Car iCar = new Upgrade.Car(2000, "Rover");
            Upgrade.House iHouse = new Upgrade.House(13000, "Becsi ut 103.");

            Upgrade.Person iPerson = new Upgrade.Person("Teszt Elek", 10);
            System.Console.WriteLine(iPerson);
            iPerson.addItem(iCar);
            iPerson.addItem(iHouse);
            System.Console.WriteLine(iPerson);

            Upgrade.Insurer iInsurer = new Upgrade.Insurer();
            iInsurer.addCar(iCar);

            iCar.accident(20);
            System.Console.WriteLine(iPerson);
            iHouse.addRoom(1500);
            System.Console.WriteLine(iPerson);
        }

        private static void Main(string[] args)
        {
            Program.testSimple();
            // Program.testSimpleExtended();
            // Program.testUpgrade();
        }
    }
}
