using System;

namespace Kazdy_Druhy_Znak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "zadřeš on i co onsemnaí";

            for (int i = 0; i < text.Length; i+=2)
            {
                Console.Write(text[i]);
            }
        }
    }
}
