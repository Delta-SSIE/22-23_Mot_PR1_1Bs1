using System;

namespace Studijni_Poradce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik procent získal žák z matematiky? ");
            int matskore = int.Parse(Console.ReadLine());
            Console.Write("Kolik procent získal žák z jazyků? ");
            int jazskore = int.Parse(Console.ReadLine());

            if (matskore >= 66 && jazskore >= 66)
            {
                if (matskore > jazskore)
                {
                    Console.WriteLine("Jdeš na techniku!");
                } else
                {
                    Console.WriteLine("Jdeš na humanitu!");
                }
            } else
            {
                Console.WriteLine("Jdeš na řemeslo!");
            }


        }
    }
}
