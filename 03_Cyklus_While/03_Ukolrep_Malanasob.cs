using System;

namespace While_malanasob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zaklad = 5;
            // Pomocná proměnná na kontrolu průchodu cyklu.
            int i = 1;

            //Cyklus se opakuje, dokud i není větší než 10 (tzn. aspoň 11)
            while (i <= 10)
            {
                Console.WriteLine($"{i}x{zaklad} = {i*zaklad}");
                //Zkracený zápis pro i = i + 1;
                i++;
            }
        }
    }
}
