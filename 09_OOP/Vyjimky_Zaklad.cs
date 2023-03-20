using System;

namespace Vyjimky_Zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vyjimky
            Console.WriteLine("Zadej číslo");
            //Try je kus kodu, který se pokusí provést
            try
            {
                int a = int.Parse(Console.ReadLine());
            }
            //Catch se spustí pokud nastane chyba a kód se neprovede správně. Zároveň program nespadne
            catch (Exception e)
            {
                //e.Message vypíše chybovou hlášku
                Console.WriteLine(e.Message);
            }

            //Ukázka s vlastní chybovou hláškou
            Console.WriteLine("Zadej číslo");
            try
            {
                int a = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Stala chyba při převodu na formát int.");
            }
        }
    }
}
