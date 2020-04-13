using System;
using System.Collections.Generic;
using System.Text;

namespace BoekClass
{
    public class Artikel
    {
        public Artikel(string naam, decimal prijs) 
        {
            Naam = naam;
            Prijs = prijs;
        }

        public string Naam { get; set; }
        public decimal Prijs { get; set; }

        public virtual void Info()
        {
            Console.WriteLine("Artikel");
            Console.WriteLine("---------");
            Console.WriteLine($"Naam: { Naam}");
            Console.WriteLine($"Prijs: { Prijs}");
            Console.WriteLine();

        }

    }
}
