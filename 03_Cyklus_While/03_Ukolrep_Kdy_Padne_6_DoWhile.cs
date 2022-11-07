using System;

namespace While_Sestka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej v programu, který hází kostkou než hodí šestku!");
            string konec = "";
            while (konec != "N")
            {
                Random kostka = new Random();
                int hozenecislo = 0;
                int hod = 0;
                do
                {
                    hozenecislo = kostka.Next(1, 7);
                    hod++;
                } while (hozenecislo != 6);

                Console.WriteLine($"Šetsku jsem hodil až na {hod} hod kostkou");
                Console.Write("Chceš hrát znovu? hru ukončíš vložením \"N\"");
                konec = Console.ReadLine();
            }
            
        }
    }
}
