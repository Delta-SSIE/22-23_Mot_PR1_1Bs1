using System;

namespace trida_pes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tento kód není třeba měnit
            
            //Vytváří se nový objekt "lord" z třídy Pes
            Pes lord = new Pes();
            //Definujeme vlastnost (položka) Jmeno objektu lord.
            lord.Jmeno = "Lord";
            //Definujeme vlastnost (položka) Nohy objektu lord.
            lord.Nohy = 4;
            //Definujeme vlastnost (položka) JeOckovany objektu lord.
            lord.JeOckovany = true;

            //Vypís metody objektu lord
            Console.WriteLine(lord.PredstavSe());

            //Zde je stejný proces, ale u nového objektku jméno "podvratak"
            Pes podvratak = new Pes();
            podvratak.Jmeno = "Vořech";
            podvratak.Nohy = 3;
            podvratak.JeOckovany = false;

            Console.WriteLine(podvratak.PredstavSe());

            //Nový objekt
            Pes alik = new Pes();
            Console.WriteLine(alik.PredstavSe());

        }
    }
}
