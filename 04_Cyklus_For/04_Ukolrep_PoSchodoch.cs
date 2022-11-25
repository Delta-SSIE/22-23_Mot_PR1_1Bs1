using System;

namespace Schody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik pater chceš?");
            int patra = int.Parse(Console.ReadLine());

            //Tenhle cyklus řeší skoky po řádcích
            for (int i = 0; i < patra; i++)
            {
                //Tenhle cyklus řeší naplnění jednotlivých řádků
                for (int a = 0; a <= i; a++)
                {
                    Console.Write("#");
                }
                //Tady se řeší, aby se vždy na konci řádku došlo k zalomení a cyklus v příštím průchodu začal na řádku novém!
                Console.WriteLine("");
            }
        }
    }
}
