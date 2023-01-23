using System;

namespace delka_tri_retezcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej 1 slovo: ");
            string slovo1 = Console.ReadLine();

            Console.Write("Zadej 2 slovo: ");
            string slovo2 = Console.ReadLine();

            Console.Write("Zadej 3 slovo: ");
            string slovo3 = Console.ReadLine();

            string nejdelsislovo = NejDelsiSlovo(slovo1, slovo2, slovo3);
            int soucetslov = SoucetSlov(slovo1, slovo2, slovo3);

            Console.WriteLine($"Celkový součet slov je {soucetslov} a nejdelší slovo je {nejdelsislovo}");
        }

        static string NejDelsiSlovo(string s1, string s2, string s3)
        {
            if (s1.Length < s2.Length)
            {
                if (s3.Length < s2.Length)
                {
                    return s2;
                } else
                {
                    return s3;
                }
            } else if (s3.Length < s1.Length)
            {
                if (s1.Length < s3.Length)
                {
                    return s3;
                } else
                {
                    return s1;
                }
            }
            return "";
        }

        static int SoucetSlov(string slovo1, string slovo2, string slovo3)
        {
            int a = slovo1.Length + slovo2.Length + slovo3.Length;
            return a;
        }

    }
}
