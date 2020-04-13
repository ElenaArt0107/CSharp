using System;
using System.Collections.Generic;
using System.Text;

namespace BoekClass
{
    public class Boek : Artikel
    {
        public string Titel { get; set; }
        public string Auters { get; set; }
        public Boek( string naam, string auters, decimal prijs) : base(naam, prijs)
        {
            this.Titel = naam;
            this.Auters = auters;

        }

        public override string ToString() // the method to overwrite the type of the class
        {
            string boekDataType = base.ToString();

            return $"{boekDataType}\n\n'Titel: {Titel}', 'Auters : {Auters}'";
        }

        public override void Info()
        {
            base.Info();

            Console.WriteLine("\tBoek");
            Console.WriteLine("\t---------------");
            Console.WriteLine($"\tTitel: {Titel}\n\tAuters : {Auters}");
            Console.WriteLine();
        }

    }
}
