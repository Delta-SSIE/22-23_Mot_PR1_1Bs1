using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace test_sprava_mesta
{
    internal class City
    {
        public int population = 0;
        public Citizen[] citizens;

        public void PridejObcana()
        {
            population++;
            if (population == 1)
            {
                citizens = new Citizen[] {
                new Citizen(population) };

            } else {
                Array.Resize(ref citizens, citizens.Length + 1);
                citizens[citizens.Length - 1] = new Citizen(population);
            }
        }

        public void VypisObcana()
        {
            Console.WriteLine("Horní věková hranice: ");
            int hor = int.Parse(Console.ReadLine());
            Console.WriteLine("Dolní věková hranice: ");
            int dol = int.Parse(Console.ReadLine());
            Console.WriteLine("Pokud chceš může zadej jedničku, naopak pro ženu zadej nulu!");
            int gen = int.Parse(Console.ReadLine());
            string gent = "";
            if (gen == 1)
            {
                gent = "man";
            } else
            {
                gent = "women";
            }

            foreach (Citizen a in citizens)
            {
                if (a.age <= hor && a.age >= dol && a.gender == gen)
                {
                    Console.WriteLine($"{a.name} is {a.age} years old {gent}");
                }
            }
        }
    }
}
