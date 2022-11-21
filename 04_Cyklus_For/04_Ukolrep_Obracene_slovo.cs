using System;

namespace obracslovo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string slovo = "zrzavy";

            //řádek níže je jediný, který budete měnit
            for (int i = slovo.Length-1; i > -1; i--)
            {
                Console.WriteLine(slovo[i]);
            }

        }
    }
}
