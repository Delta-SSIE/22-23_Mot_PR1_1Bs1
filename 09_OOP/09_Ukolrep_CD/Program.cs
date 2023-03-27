using System;

namespace CD_disk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvořen nový objekt jménem "CD1"
            CompactDisk CD1 = new CompactDisk();

            //Nadefinovat jednotlivý fields pro obejkt CD1
            CD1.Title = "Waterloo";
            CD1.Artist = "ABBA";
            CD1.Year = 1974;
            CD1.Tracks =  new string[] {"Waterloo","Sitting in the Palmtree","King Kong Song","Hasta Mañana"};

            //Vypíšu návratovou hodnotu
            Console.WriteLine(CD1.Description());

        }
    }
}
