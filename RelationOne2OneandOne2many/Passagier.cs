using System;
using System.Collections.Generic;
using System.Text;

namespace RelationOne2OneandOne2many
{
    // // 1. Maak van Passagier en Auto een class met de eigenschappen te zien in het klassendiagram
    // first Passagier as it will be used as a reference type in a class Auto
    class Passagier
    {
        public string naam;
        public int leeftijd;

        public Passagier(string naam, int leeftijd)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
        }

        /// 3. Maak voor beide classen, een Info method waarbij je alle eigenschappen toont////////

        public void Info()
        {
            Console.WriteLine("Passagier\n");
            Console.WriteLine($"Naam van Passagier {naam}");
            Console.WriteLine($"leeftijd van Passagier {leeftijd}");

        }

    }
}
