using System;
using System.Collections.Generic;
using System.Text;

namespace RelationOne2Many
{
    class Auto
    {
        private const int maxPasagiers = 5;
        public string merk;
        public string kleur;
        public List<Passagier> passagiers;

        public Auto(string merk, string kleur)
        {
            this.merk = merk;
            this.kleur = kleur;

            passagiers = new List<Passagier>();



        }

        //2. 2 Tweede waarbij je een volledige passagier meestuurt

        public Auto(string merk, string kleur, List<Passagier> passagiers)
        {
            this.merk = merk;
            this.kleur = kleur;
            this.passagiers = passagiers;
        }

        /// 3. Maak voor beide classen, een Info method waarbij je alle eigenschappen toont////////

        public void Info()
        {
            Console.WriteLine("Auto\n");
            Console.WriteLine($"Merk van Auto {merk}");
            Console.WriteLine($"kleur van Auto {kleur}");
            Console.WriteLine();

            foreach (var p in passagiers)
            {
                p.Info();
            }
        }

        
        public void AddPasagier(Passagier p)
        {
            Console.WriteLine("Pasagiers: \n");
            if (passagiers.Count >= maxPasagiers)
            {
                Console.WriteLine($"Max pasagiers is {maxPasagiers}");
            }
            else
            {
                passagiers.Add(p);
            }
        }
    }
}
