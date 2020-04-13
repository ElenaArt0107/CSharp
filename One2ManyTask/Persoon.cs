using System;
using System.Collections.Generic;
using System.Text;

namespace One2ManyTask
{
    class Persoon
    {
        private const int maxDieren = 5;
        public string naam;
        public DateTime gebortedatum;
        public List <Huisdier> huisdier;

        //Één waarbij je de naam en de Geboortedatum van de Persoon vraagt

        public Persoon(string naam, DateTime gebortedatum) // ctop + tab shortcut
        {
            this.naam = naam;
            this.gebortedatum = gebortedatum;

            huisdier = new List < Huisdier > ();
        }
        //Tweede waarbij Geboortedatum van de Persoon vraagt EN een lijst met huisdieren

        public Persoon(string naam, DateTime gebortedatum, List<Huisdier> huisdier) // ctop + tab shortcut
        {
            this.naam = naam;
            this.gebortedatum = gebortedatum;

            this.huisdier = huisdier;
        }

        public void Info()
        {
            Console.WriteLine("Persoon\n");
            Console.WriteLine($"Persoon naam :  {naam}");
            Console.WriteLine($"Persoon gebortedatum : {gebortedatum}");
            Console.WriteLine();

            Console.WriteLine($"huisdieren van {naam}: \n");
            foreach (var h in huisdier)
            {
                h.Info();
            }
        }


        public void AddPet(Huisdier h)
        {
            
            if (huisdier.Count >= maxDieren)
            {
                Console.WriteLine($"Max huisdieren is {maxDieren}");
            }
            else
            {
                huisdier.Add(h);
            }
        }
    }
}
