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

            //Oběšenec, trénink indexování
            Console.WriteLine("Vítej ve hře Šibenice. Nejdříve zadej slovo složené z 3 písmen");
            string hadanka = Console.ReadLine();
            string uhodl = "";
            int skore = 0;

            Console.Write("Hádej první písmeno ");
            char p1 = char.Parse(Console.ReadLine());
            if (p1 == hadanka[0])
            {
                skore = skore + 1;
                uhodl = uhodl + p1;
            } else
            {
                uhodl = uhodl + " ";
            }

            Console.Write("Hádej druhé písmeno ");
            char p2 = char.Parse(Console.ReadLine());
            if (p2 == hadanka[1])
            {
                skore = skore + 1;
                uhodl = uhodl + p2;
            }
            else
            {
                uhodl = uhodl + " ";
            }

            Console.Write("Hádej třetí písmeno ");
            char p3 = char.Parse(Console.ReadLine());
            if (p3 == hadanka[2])
            {
                skore = skore + 1;
                uhodl = uhodl + p3;
            }
            else
            {
                uhodl = uhodl + " ";
            }

            Console.WriteLine($"Konec hry. Z tajenky ti vychází: {uhodl} a získal si {skore} bod/y!");

            //Speciální
            Console.WriteLine("Jednoduchou uvozovku napšíše \' a dvojitou takhle \" .");
            Console.WriteLine("Řádek se zalamuje \nTohle je nový řádek, který také zalomím \nTohle je nový řádek!");
        }
    }
}
 