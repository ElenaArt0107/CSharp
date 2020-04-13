using System;
using System.Collections.Generic;
using System.Text;

namespace PersoonClass
{
   public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string VolledigeNaam  => $"{Voornaam} {Naam}"; //witout  { get; set; }
        public int Leeftijd { get; set; }

        public Persoon(string naam, string voornaam)
        {
            this.Voornaam = voornaam;
            this.Naam = naam;
        }
        // to customize the ToString method from Object.Methods
        //public override string ToString() // new key word override means
        //{
        //    return VolledigeNaam;
        //}
        public override string ToString() // new key word override means
        {
           string volledigeNaamDataType =  base.ToString() ; // key word -reference to our base class
            return $"{volledigeNaamDataType} -> { VolledigeNaam}";
        }

        public virtual void Info() // we use as key word virtual to be able to inharite this method
        {
            Console.WriteLine("Persoon");
            Console.WriteLine($"{VolledigeNaam}");

        }
    }
}
