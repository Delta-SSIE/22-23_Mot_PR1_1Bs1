using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Pes_II
{
    internal class Pes
    {
        private string jmeno;
        private int nohy;
        private bool jeockovany;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public int Nohy
        {
            get { return nohy; }
            set
            {
                if (value > 4 || value < 0)
                {
                    nohy = 4;
                } else
                {
                    nohy = value;
                }
            }
        }

        public bool JeOckovany
        {
            get { return jeockovany; }
            set { jeockovany = value; }
        }

        public string PredstavSe()
        {
            return $"Já jsem pes, jmenuju se {Jmeno}, mám {Nohy} nohy a {(JeOckovany ? "jsem" : "nejsem")} očkovaný.";
        }
    }
}
