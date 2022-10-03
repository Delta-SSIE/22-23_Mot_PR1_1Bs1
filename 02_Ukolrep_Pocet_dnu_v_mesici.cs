using System;

namespace Dny_v_mesicich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo měsíce! (povolené vstupy 1–12)");
            int mesic = int.Parse(Console.ReadLine());

            if (mesic > 12 || mesic <= 0)
            {
                Console.WriteLine("Zadal si nesmysl!");
            } else if (mesic == 2)
            {
                Console.WriteLine("Váš měsíc má 28 dnů");
            } else if (mesic == 4 || mesic == 6 || mesic == 9 || mesic == 11)
            {
                Console.WriteLine("Váš měsíc má 30 dnů");
            } else
            {
                Console.WriteLine("Váš měsíc má 31 dnů");
            }
        }
    }
}
