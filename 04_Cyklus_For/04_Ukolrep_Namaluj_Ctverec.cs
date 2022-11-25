using System;

namespace ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej délku strany a: ");
            int a = int.Parse(Console.ReadLine());
            
            //Cyklus řeší skoky po řádcích
            for (int i = 0; i < a; i++)
            {
                //Cyklus řeší naplnění řádků #
                for (int x = 0; x < a; x++)
                {
                    Console.Write("#");
                }
                //Zalomení řádku, aby další průchod začal na novém řádku!
                Console.WriteLine();
            }
        }
    }
}
