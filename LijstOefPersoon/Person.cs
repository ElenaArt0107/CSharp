using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Persoon
    {
        public string voornaam;
        public string familiennaam;

        public void Descript()
        {
            Console.Write(voornaam + " " + familiennaam);
        }


        public Persoon(string voornaam, string familiennaam)
        {
            this.voornaam = voornaam;
            this.familiennaam = familiennaam;
        }

    }
}
