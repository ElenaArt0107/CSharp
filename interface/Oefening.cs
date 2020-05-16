using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract1
{
    public abstract class Oefening
    {
        protected Random _rndGenerator;
        public string Naam { get; protected set; }
        public abstract string Vraag { get; } // abstract should be always public !!!
        protected int Getal1 { get; set; }
        protected int Getal2 { get; set; }
        public int Aantwoord { get; set; } // not protected as we will get info from main class (not a chid one)
        public int Oplossing { get; protected set; }

        public Oefening(string naam, Random rnd)
        {
            if (rnd == null)
            {
                throw new Exception("Random moet niet null zijn");
            }
            Naam = naam;
            _rndGenerator = rnd;
        }
        public abstract void GenereerOefening();
        
        public bool IsCorrectGeantwoord() //automatically true 
        {
            return Oplossing == Aantwoord; // returns true checking the condition
        }

    }
}
