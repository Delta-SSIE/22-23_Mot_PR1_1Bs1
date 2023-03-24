using System;

namespace enumerace_karty
{
    enum karty : byte
    {
        sedma = 7,
        osma,
        devítka,
        desítka,
        spodek,
        filek,
        král,
        eso
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uložení z enum do proměnné
            karty karta = karty.král;
            Console.WriteLine(karta);

            //Posun enum listu o jedna dopředu
            karta++;
            Console.WriteLine(karta);

            KdoJeVyssi(karty.eso, karty.spodek);
            KdoJeVyssi(karty.sedma, karty.desítka);
            KdoJeVyssi(karty.desítka, karty.desítka);

        }

        static void KdoJeVyssi(karty kartaA, karty kartaB)
        {
            if (kartaA > kartaB)
            {
                Console.WriteLine($"Vyšší je {kartaA}");
            } else if (kartaA == kartaB)
            {
                Console.WriteLine("Karta mají stejnou hodnotu");
            } else
            {
                Console.WriteLine($"Vyšší je {kartaB}");
            }
        }
    }
}
