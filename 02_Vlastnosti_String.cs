using System;

namespace Vlastnosti_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "AbCdE  K+  4+5";
            string text2 = "Hello";

            //Délka řetězce
            Console.WriteLine(text.Length);

            //Capslock – Velký a malý písmena
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());

            //Propojení textu
            Console.WriteLine(text + text2);
            //Propojení skrz Concat
            Console.WriteLine(string.Concat(text,text2));

            //Výpis proměnných
            Console.WriteLine("Text sms je " + text + ". Konec sms!");
            //Placeholder výpis
            Console.WriteLine($"Text sms je {text}. Konec sms!");

            //Indexování znaku
            Console.WriteLine(text2[2]);
            Console.WriteLine(text[7]);

            //Hledání indexu
            Console.WriteLine(text.IndexOf("+"));

            //Výpis od indexu
            Console.WriteLine(text.Substring(7));

            //Oběšenec

        }
    }
}
