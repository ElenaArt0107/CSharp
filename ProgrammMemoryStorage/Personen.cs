using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammMemoryStorage
{
    class Personen
    {
        public string naam;
        public DateTime gebortedatum;
        public Huisdieren huisdier;

        public Personen(string naam, DateTime gebortedatum, string naamHuisdier, string soortHuisdier) // ctop + tab shortcut
        {
            this.naam = naam;
            this.gebortedatum = gebortedatum;

            Huisdieren h = new Huisdieren(naamHuisdier, soortHuisdier);

            this.huisdier = h;
        }
        public Personen(string naam, DateTime gebortedatum, Huisdieren h) // ctop + tab shortcut
        {
            this.naam = naam;
            this.gebortedatum = gebortedatum;
            this.huisdier = h;
        }

        public void Info()
        {
            Console.WriteLine("Persoon");
            Console.WriteLine($"Naam van hersoon {naam}");
            Console.WriteLine(huisdier.naam); // not the best practice why?
            Console.WriteLine(huisdier.soort);



        }
    }
}
