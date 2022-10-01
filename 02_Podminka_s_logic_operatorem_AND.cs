using System;

namespace Podmínky_s_logickým_operátorem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heslo1 = "pes";
            string heslo2 = "letadlo";

            Console.Write("Nyní zadá uživatel 1 své heslo: ");
            string zadheslo1 = Console.ReadLine();
            Console.Write("Nyní zadá uživatel 2 své heslo: ");
            string zadheslo2 = Console.ReadLine();
            
            //Použití logického opearátoru AND
            if (heslo1 == zadheslo1 && heslo2 == zadheslo2)
            {
                Console.WriteLine("Autodestrukce spuštěna");
            }

            //To stejné bez AND
            if (heslo1 == zadheslo1)
            {
               if (heslo2 == zadheslo2)
                {
                    Console.WriteLine("Autodestrukce spuštěna");
                }
            }
        }
    }
}
