using System;
using System.Collections.Generic;
using System.Text;

namespace One2ManyTask
{
    class Huisdier
    {
        public string naam;
        public string soort;

        public Huisdier(string naam, string soort) // ctop + tab shortcut
        {
            this.naam = naam;
            this.soort = soort;
        }

        public void Info()
        {

            Console.WriteLine($"naam : {naam}");
            Console.WriteLine($"soort : {soort}");
            Console.WriteLine();

        }
    }
}
