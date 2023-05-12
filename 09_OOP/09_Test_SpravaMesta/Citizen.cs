using System;
using System.Collections.Generic;
using System.Text;

namespace test_sprava_mesta
{
    internal class Citizen
    {
        public int number;
        public string name;
        public int age;
        public int gender;

        public Random generator = new Random();
        public int nahodcislo = 0;

        public Citizen(int cislo)
        {
            number = cislo;
            nahodcislo = generator.Next(0, 50);
            string[] names = { "Ethan", "Olivia", "Noah", "Ava", "Liam", "Isabella", "Mason", "Sophia", "Jacob", "Mia", "William", "Charlotte", "Elijah", "Amelia", "James", "Harper", "Benjamin", "Evelyn", "Lucas", "Abigail", "Alexander", "Emily", "Michael", "Elizabeth", "Daniel", "Mila", "Matthew", "Ella", "Aiden", "Avery", "Henry", "Scarlett", "Joseph", "Victoria", "Samuel", "Chloe", "David", "Grace", "Owen", "Sofia", "Emma", "Madison", "Avery", "Lily", "Natalie", "Landon", "Hannah", "Levi", "Aria", "Dylan", "Layla" };
            name = names[nahodcislo];
            age = nahodcislo + 18;
            if (nahodcislo % 2 == 0)
            {
                gender = 0;
            } else
            {
                gender = 1;
            }
        }
    }
}
