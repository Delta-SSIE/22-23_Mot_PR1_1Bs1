using System;

namespace Vetveni_programu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Boolean datový typ
            
            int x = 5;
            int y = 10;
            
            // Boolean datový typ 
            bool vyssi = x > y;
            Console.WriteLine(vyssi);
            
            */

            /* První použití proměnné IF
            
            string heslo = "heslo123";
            string zadaneheslo = Console.ReadLine();
            if (zadaneheslo == heslo) 
            {
                //tohle se spustí pokud podmínka bude TRUE
                Console.WriteLine("Jste přihlášen!");
            }
            Console.WriteLine("Konec programu!");
            
             */

            //Vyšší číslo (úloha v replitu)
            Console.WriteLine("Zadej mi proměnné a já ti řeknu, která je vyšší");
            Console.Write("Zadej X: ");
            int numx = int.Parse(Console.ReadLine());
            Console.Write("Zadej Y: ");
            int numy = int.Parse(Console.ReadLine());

            /* Základní if bez else
            if (numx > numy)
            {
                Console.WriteLine($"Číslo {numx} je větší než {numy}");
            }
            if (numy > numx)
            {
                Console.WriteLine($"Číslo {numy} je větší než {numx}");
            }
            if (numy == numx)
            {
                Console.WriteLine("Číslo " + numy + " je stejné číslo jako " + numx );
            }
            */

            /* Podmínka if s else
            if (numx > numy)
            {
                Console.WriteLine($"Číslo {numx} je větší než {numy}");
            } else
            {
                Console.WriteLine($"Číslo {numy} je větší než {numx}");
            }
            */

            //Podmínka if a else if
            if (numx > numy)
            {
                Console.WriteLine($"Číslo {numx} je větší než {numy}");
            }
            else if (numy > numx)
            {
                Console.WriteLine($"Číslo {numy} je větší než {numx}");
            } else
            {
                Console.WriteLine("Číslo " + numy + " je stejné číslo jako " + numx);
            }


        }
    }
}
