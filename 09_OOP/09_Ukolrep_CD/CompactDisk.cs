using System;
using System.Collections.Generic;
using System.Text;

namespace CD_disk
{
    internal class CompactDisk
    {
        //Položky
        public string Title;
        public string Artist;
        public int Year;
        public string[] Tracks;

        //Metodu
        public string Description()
        {
            string zprava = $"\"{Title}\" by {Artist} was published at {Year}. It contains {Tracks.Length} tracks";
            return zprava;
        }
    }
}
