using System;

namespace Je_pole_rostouci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla1 = { -5, -3, 1, 7, 50 };
            int[] cisla2 = { -5, 1, -3, 7, 50 };
            int[] cisla3 = { -5, -3, 1, 1, 7, 50 };

            //je
            Console.WriteLine("První pole {0} rostoucí.", JeRostouci(cisla1) ? "je" : "není");

            //není
            Console.WriteLine("Druhé pole {0} rostoucí.", JeRostouci(cisla2) ? "je" : "není");

            //není
            Console.WriteLine("Třetí pole {0} rostoucí.", JeRostouci(cisla3) ? "je" : "není");
        }

        static bool JeRostouci(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (i == pole.Length-1)
                {

                }
                else
                {
                    if (pole[i] >= pole[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}

