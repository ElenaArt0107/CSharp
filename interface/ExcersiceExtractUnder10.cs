using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract1
{
    public class ExcersiceExtractUnder10 : Oefening
    {
        public override string Vraag => $"What is the difference between {Getal1} en {Getal2}";
        public ExcersiceExtractUnder10(string name, Random rnd) : base (name, rnd)
        {
        }
           

        public override void GenereerOefening()
        {
            do
            {
                Getal1 = _rndGenerator.Next(1, 10); // the accessor is unaccessible, to solve it - chanche into protected from private
                Getal2 = _rndGenerator.Next(1, 10);
            }
            while (Getal1 - Getal2 > 10 || Getal1 - Getal2 < 0);

            Oplossing = Getal1 - Getal2;
        }

    }
}
