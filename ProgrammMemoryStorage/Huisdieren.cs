using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammMemoryStorage
{
    class Huisdieren
    {
        public string naam;
        public string soort;

        public Huisdieren(string naam, string soort) // ctop + tab shortcut
        {
            this.naam = naam;
            this.soort = soort;
        }

        public void Info ()
        {
            Console.WriteLine("Huisdier");
            Console.WriteLine($"naam : {naam}");
            Console.WriteLine($"soort : {soort}");

        }
    }
}
