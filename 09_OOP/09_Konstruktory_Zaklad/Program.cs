using System;
using System.IO.Compression;

namespace Konstruktory_Zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba objektů s argumenty pro konstruktor
            Animal leopard = new Animal(4, "Josse");
            Animal zirafa = new Animal(4, "Jane");
            Animal ryba = new Animal(0, "Dave");

            leopard.PredstavSe();
            zirafa.PredstavSe();
            ryba.PredstavSe();
        }
    }
}
