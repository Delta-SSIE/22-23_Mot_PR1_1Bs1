using System;

namespace While_heslo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš heslo: ");
            string zadheslo = Console.ReadLine();
            string heslo = "ahoj123";

            // Začátek cyklu, ten se bude opakovat, dokud se zadheslo nebude shodovat s heslem.
            while (zadheslo != heslo)
            {
                //Console.Clear slouží k vyčištění konzole
                Console.Clear();
                Console.WriteLine("Zadali jste nesprávné heslo!");
                Console.Write("Zadej heslo znovu: ");
                zadheslo = Console.ReadLine();
            }

            Console.WriteLine("Gratlujeme, úspěšně jste se přihlásil do systému!");
        }
    }
}
