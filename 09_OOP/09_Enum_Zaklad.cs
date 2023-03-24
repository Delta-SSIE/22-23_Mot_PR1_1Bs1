using System;

namespace Enum_zaklad
{
    enum Dny
    {
        Pondeli,//0
        Utery,  //1
        Streda, //2
        Ctvrtek,//3
        Patek,  //4
        Sobota, //5
        Nedele  //6
    }

    enum Mesice
    {
        Leden,  //0
        Unor=6, //6
        Brezen  //7
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace proměnné z enum
            Dny dnesden = Dny.Pondeli;
            //Výpis proměnné
            Console.WriteLine(dnesden);
            //Posun o jedna dopředu v enum
            dnesden++;
            Console.WriteLine(dnesden);
            //Posun o jedna dozadu v enum
            dnesden--;
            Console.WriteLine(dnesden);

            //Index z enum
            int indexenum = (int)Dny.Streda;
            Console.WriteLine(indexenum);

            //Index z posunutého pole
            int indexmesic = (int)Mesice.Brezen;
            Console.WriteLine(indexmesic);

        }
    }
}
