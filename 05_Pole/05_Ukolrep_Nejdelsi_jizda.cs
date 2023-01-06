using System;

namespace Nejdelsi_jizda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] jizdy = {
            247,
            135,
            15,
            23,
            428,
            63,
            26,
            7
        };

            string[] ridici = {
            "Petr",
            "Pavel",
            "Jaroslav",
            "Pavel",
            "Jaroslav",
            "Petr",
            "Pavel",
            "Petr"
        };
            //Pomocné proměnné pro počítání maxima. Ukládám si tam rovnou první prvek pole a jeho id.
            int max = jizdy[0];
            int maxid = 0;

            for (int i = 1; i < jizdy.Length; i++)
            {
                //Kontroluji jestli právě procházený prvek je vyšší než to, co je uložené v max, případně je to přepsáno.
                if (max < jizdy[i])
                {
                    max = jizdy[i];
                    maxid = i;
                }
            }

            //Řidiče pak získám, že adresuji jejich pole a používám index nejvyššího čísla v poli jízda.
            Console.WriteLine("Nejdelší jízda je " + max +  " a tuto jízdu vykonal " + ridici[maxid]) ;
        }
    }
}
