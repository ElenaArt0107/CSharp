using System;
using System.Collections.Generic;
using System.Text;

namespace RelationOne2OneandOne2many
{
    // 1. Maak van Passagier en Auto een class met de eigenschappen te zien in het klassendiagram

    class Auto
    {
        public string merk;
        public string kleur;
        public Passagier passagier; // passagier as a feature is in the table of Auto


        //2. Maak voor passagier één constructor en Auto twee constructors


        //2. 1 Één waarbij je de naam en de leeftijd van de passagier vraagt

        public Auto (string merk, string kleur, string nnamPassagier, int leeftijdPassagier)
        {
            this.merk = merk;
            this.kleur = kleur;

            Passagier p = new Passagier(nnamPassagier, leeftijdPassagier);

            this.passagier = p;

        }

        //2. 2 Tweede waarbij je een volledige passagier meestuurt

        public Auto(string merk, string kleur, Passagier p)
        {
            this.merk = merk;
            this.kleur = kleur;

            this.passagier = p;

        }

        /// 3. Maak voor beide classen, een Info method waarbij je alle eigenschappen toont////////

        public void Info()
        {
            Console.WriteLine("Auto\n");
            Console.WriteLine($"Merk van Auto {merk}");
            Console.WriteLine($"kleur van Auto {kleur}");
            Console.WriteLine();

            //////////// 3. 1 Zorg ervoor dat je in de Info method van Auto, de info method van passagier oproept////////////


            //Console.WriteLine(passagier.naam); 
            //Console.WriteLine(passagier.leeftijd);
            // not the best practice why? 1. to avoid typo, 2. good practice is ->
            //more and better to delegate via the function passagier.Info()

            passagier.Info();


        }
    }
}
