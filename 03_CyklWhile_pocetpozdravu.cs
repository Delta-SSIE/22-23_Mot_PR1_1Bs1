using System;

namespace While_vypis_dle_zadaneho_poctu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolikrát tě má program pozdravit: ");
            int pocetpozdrav = int.Parse(Console.ReadLine());
            //Pomocná proměnná na počítání průchodu cyklu.
            int i = 1;

            while (i <= pocetpozdrav)
            {
                Console.WriteLine("Hello World!");
                //zváýšení proměnné o 1
                i++;
            }
        }
    }
}
