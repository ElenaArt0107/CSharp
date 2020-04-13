using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_9._1_Vrienden
{
    class Persoon
    {
        public string naam;

        public Persoon (string naam)
        {
            this.naam = naam;
        }
        public void ZwaaiVriendUit(string vriend)
        {
            Console.WriteLine($"{naam} zwaait {vriend} uit.");
        }

        public void VerwelkomVriend(string vriend)
        {
            Console.WriteLine($"{naam} verwelkomt {vriend}.");
        }
    }
}
