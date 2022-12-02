using System;

namespace trojuhelnik_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;

            // Vnější cyklus, který řeší řádky
            for (int i = strana; i > 0; i--)
            {
                //Vnitřní cyklus, který řeší naplňování řádků
                for (int x = 1; x < strana+1; x++)
                {
                    //Podmínka, která řeší, jestli následující znak je mezera, či hash
                    if (i > x)
                    {
                        Console.Write(" ");
                    } else
                    {
                        Console.Write("#");
                    }
                }
                //Odskočení o řádek níže!
                Console.WriteLine();
            }
        }
    }
}
