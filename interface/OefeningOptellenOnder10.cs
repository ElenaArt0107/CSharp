using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract1
{
    class OefeningOptellenOnder10 : Oefening // we havew to override all the abstract parameters and methods from this class
    {
        public override string Vraag => $"Wat is de som van {Getal1} en {Getal2}";
        public OefeningOptellenOnder10(string naam, Random rnd) : base (naam, rnd)
        {

        }
             

        public override void GenereerOefening()
        {///private can be used only inside a class, protected can be used in the children classes as well
         ///
            //Getal1 = 0;
            //Getal2 = 0;

            do
            {
                Getal1 = _rndGenerator.Next(1, 10); // the accessor is unaccessible, to solve it - chanche into protected from private
                Getal2 = _rndGenerator.Next(1, 10);
            }
            while (Getal1 + Getal2 > 10);

            Oplossing = Getal1 + Getal2;
        }
    }
}
