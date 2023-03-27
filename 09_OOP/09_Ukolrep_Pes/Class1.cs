using System;
using System.Collections.Generic;
using System.Text;

namespace trida_pes
{
    internal class Pes
    {
        //Tvorba fields (položek) / vlastností dané třídy.
        public string Jmeno = "Alik";
        public int Nohy = 4;
        public bool JeOckovany = false;

        //metoda s návratovou hodnotou dané třídy!
        public string PredstavSe()
        {
            string zprava = $"Já jsem pes, jmenuju se {Jmeno}, mám {Nohy} nohy a ";
            if (JeOckovany == true)
            {
                zprava = zprava + "jsem očkovaný";
            } else
            {
                zprava = zprava + "jsem neočkovaný";
            }
            return zprava;
        }
    }
}
