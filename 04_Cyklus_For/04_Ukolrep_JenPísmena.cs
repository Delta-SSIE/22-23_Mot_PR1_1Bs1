using System;

namespace Nechte_Jen_Pismena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Jean-Luc, you should inform no. 1 and then go and see what happened at 8:30PM!";
            string final = "";
            int a = 0;
            for (int i = 0; i < text.Length; i++)
            {
                //Konvertuji znak na číslo
                a = (int)Convert.ToChar(text[i]);
                //Zjištuji, zda-li dané číslo je v rozmezí, kdy se mu jednat o znak
                if((a < 91 && a > 64) || (a < 123 && a > 96))
                {
                    //Znak přidávám k finálnímu stringu
                    final += text[i];
                }
            }
            Console.WriteLine(final);
        }
    }
}
