using System;
using System.Collections.Generic;
using System.Text;

namespace abstractExerciseLes
{
    public class Whale : Mammals
    {
        public override string Sort => "Mammal";

        public override void MakeSound()
        {
            Console.WriteLine("Woooooo!");
        }

    }
}
