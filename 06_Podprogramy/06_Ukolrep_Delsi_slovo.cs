using System;
using System.Security.Cryptography.X509Certificates;

namespace delsi_slovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej první slovo: ");
            string slovo1 = Console.ReadLine();

            Console.Write("Zadej druhé slovo: ");
            string slovo2 = Console.ReadLine();

            string delsiSlovo = Delsislovo(slovo1, slovo2);
            Console.WriteLine($"Když porovnáme {slovo1} a {slovo2}, pak delší je {delsiSlovo}.");
        }

        static string Delsislovo(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return s1;
            } else if (s2.Length > s1.Length)
            {
                return s2;
            } else
            {
                return "žádné. Slova jsou stejně dlouhá";
            }
        }
    }
}
