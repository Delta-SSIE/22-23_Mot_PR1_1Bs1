using System;

namespace velka_pismena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Aspoň trochu ovsa, Karlíku, tomu koni dej. Copak nevidíš, že mu Eva zapomněla nasypat a Zdeněk tu dnes není. Ani Čeněk nedělá, co by měl. Nevím proč vás Evelína nevyhnala. Všichni byste Evelíně měli poděkovat. Třeba Řehoř a Iva, taky se pořád někde potulují. Dejvice, Emauzy, Strašnice, Ejpovice, ale být doma, to ne. To bych toho po vás chtěl moc.";
            int a = 0;

            //Pomocí metody Split rozdělíme řetězec na jednotlivá pole 
            string[] poletextu = text.Split(' ');

            //Foreach na průchod skrz pole polettextu
            foreach (string x in poletextu)
            {
                //Konvertuji první znak daného načetlého čísla
                a = (int)Convert.ToChar(x[0]);
                //65 až 90 jsou číselné hodnoty velkých písmen v ASCII tabulce
                if (a > 64 && a < 91)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
