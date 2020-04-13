using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesGettersAndSetters
{
    class Rekkenen
    {
        private string naam; //not public because ? 
                             //for every feature we're going to use getter
        private int bedraag;

        public Rekkenen(string naam)
        {
            this.naam = naam;
            bedraag = 0;
        }
        // always returs one value, so it's not void
        public string GetNaam()
        {
            return naam;
        }

        public int GetBedraag()
        {
            return bedraag;
        }
        /////setter is always void , have 1 input parameter
        /// in setter we cen put also the check

        public void SetNaam(string naam)
        {
            this.naam = naam;
        }

        public void SetBedraag(int bedraag)
        {
            if (bedraag < 0)
            {
                Console.WriteLine("must be not negative plz");
                return;
            }
            this.bedraag = bedraag;
        }
    }
}
