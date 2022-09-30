using System;

namespace Vetveni_programu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            
            // Boolean datový typ 
            bool vyssi = x > y;
            Console.WriteLine(vyssi);

            //První použití proměnné IF
            string heslo = "heslo123";
            string zadaneheslo = Console.ReadLine();
            if (zadaneheslo == heslo) 
            {
                //tohle se spustí pokud podmínka bude TRUE
                Console.WriteLine("Jste přihlášen!");
            }
            Console.WriteLine("Konec programu!");


        
        }
    }
}
