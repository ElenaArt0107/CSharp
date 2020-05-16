using System;
using System.Collections.Generic;
using System.Text;

namespace abstractExerciseLes
{
    public class Fish : Animal
    {
        public override string Sort => "Animal";

        public override void MakeSound()
        {
            Console.WriteLine("Bulk... bulk"); ;
        }
    }
}
