using System;

namespace Cyklus_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                //Úplně stejně by šlo napsat ($"Hodnota i je {i}"), nebo ("Hodnota i je" + i)
                Console.WriteLine("Hodnota i je {0}", i);
            }
        }
    }
}
