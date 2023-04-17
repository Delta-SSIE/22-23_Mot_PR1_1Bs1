using System;
using System.Collections.Generic;
using System.Text;

namespace Tabulka_Cokolady
{
    internal class Tabulka
    {
        private string znacka;
        private int hmotnost;
        private string druh;

        public string Znacka
        {
            get { return znacka; }
            set
            {
                znacka = value;
            }
        }

        public int Hmotnost
        {
            get { return hmotnost; }
            set
            {
                if (value > 1000)
                {
                    hmotnost = 1000;
                }
                else
                {
                    hmotnost = value;
                }
            }
        }
        public string Druh
        {
            get { return druh; }
            set
            {
                if (value != "Hořká" || value != "Mléčná" || value != "Bílá")
                {
                    druh = "Mléčná";
                }
                else
                {
                    druh = value;
                }
            }
        }

        public int Odlom()
        {
            int odlomek;
            if (Hmotnost > 10)
            {
                odlomek = Hmotnost / 2;
                Hmotnost -= odlomek;
            } else
            {
                odlomek = Hmotnost;
                Hmotnost = 0;
            }
            return odlomek;
        }
         
    }
}
