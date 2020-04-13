using System;
using System.Collections.Generic;
using System.Text;

namespace Les4ListContinue
{
    public enum BijJob // type 
    {
        NectarCollector,
        StingPatrol,
        HiveMaintenance,
        BabyBeeTutoring,
        EggCare,
        HoneyManufacturing
    }

    class Bij
    {
      public BijJob job; // we created a new type, it's not a string anymore
        public Bij(BijJob job) // we created a new type, it's not a string anymore
        {
            this.job = job;
        }

        public void Toon()
        {
            Console.WriteLine($"I'm a {job}");
        }
    }
}
