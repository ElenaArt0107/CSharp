using System;
using System.Collections.Generic;
using System.Text;

namespace RelationOne2Many
{
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
            Console.WriteLine($"Naam van Passagier {naam}");
            Console.WriteLine($"leeftijd van Passagier {leeftijd}");

        }
    }
}
