using System;
using System.Collections.Generic;
using System.Text;

namespace PersoonClass
{
    public class Volwassene : Persoon
    {
        public bool Gehuwd { get; set; }
        public bool Kinderen { get; set; }
        public string Beroep { get; set; }

        public Volwassene(string naam, string vN, bool gehuwd, bool kinderen, string beroep) : base(naam, vN)
        {
            Gehuwd = gehuwd;
            Kinderen = kinderen;
            Beroep = beroep;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("\t Volwassene");
            Console.WriteLine("---------------");
            Console.WriteLine($"Gehuwd : {Gehuwd}");
            Console.WriteLine($"Kinderen : {Kinderen}");
            Console.WriteLine($"Beroep: {Beroep}");
        }
    }
}
