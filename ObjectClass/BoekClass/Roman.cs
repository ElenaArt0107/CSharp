using System;
using System.Collections.Generic;
using System.Text;

namespace BoekClass
{
    public class Roman: Boek
    {

        public string GewonnenPrijzen { get; set; }

        public Roman(string naam, decimal prijs, string auters, string gewonnenPrijzen): base(naam, auters, prijs)
        {
            this.GewonnenPrijzen = gewonnenPrijzen;
        }

        public override void Info()
        {
            base.Info();

            Console.WriteLine("\t\tRoman");
            Console.WriteLine("\t\t--------");
            Console.WriteLine($"\t\tGewonnenPrijzen: {GewonnenPrijzen}");
            Console.WriteLine();
        }
    }
}
