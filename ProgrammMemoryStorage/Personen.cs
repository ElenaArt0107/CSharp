using Microsoft.Win32.SafeHandles;
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

        // constructor
        public Personen(string naam, DateTime gebortedatum, string naamHuisdier, string soortHuisdier) // ctor + tab shortcut
        {
            this.naam = naam;
            this.gebortedatum = gebortedatum;

            Huisdieren h = new Huisdieren(naamHuisdier, soortHuisdier); // out of the parameters as a new object, but in the parameters in the e.g. below
            this.huisdier = h;
        }
        //overload of a class constructor the same as an overloading of methods = to add the class with the same name but additional paraneters
        public Personen(string naam, DateTime gebortedatum, Huisdieren h) // ctor + tab shortcut
        {
            this.naam = naam;
            this.gebortedatum = gebortedatum;
            this.huisdier = h;
        }

        public void Info()
        {
            Console.WriteLine("Persoon");
            Console.WriteLine($"Naam van persoon {naam}");
            Console.WriteLine();
            huisdier.Info();
            //Console.WriteLine(huisdier.naam); 
            //Console.WriteLine(huisdier.soort);  // these 2 last are not the best practice why? because it doesn't show the whole info , 
            //just a part  and if amth canges in the info method, it should be rewritten here as well




        }
    }
}
