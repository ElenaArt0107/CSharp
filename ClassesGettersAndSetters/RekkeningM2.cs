using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesGettersAndSetters
{
    class RekkeningM2
    {
        //private int myVar; // proptfull and doble tab - the template for getters and setter as features

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        private string _naam; //not public because ? 
                             //for every feature we're going to use getter
        private int _bedraag; // underscore + little letter for private and public must start from CapitalLetter as well as methods

        public RekkeningM2(string naam, int bedraag)
        {
            this._naam = naam;
            this._bedraag = bedraag;
        }

        /// <summary>
        ///  Getters -the 2nd option as a features not a method!!!
        /// </summary>
        public string Naam //no features
        {
            get
            {
                return _naam;
            }
            set
            {
                //string futureNaam = value;  //smth we will give into
                //_naam = futureNaam;

                _naam = value;
            }
        }

        public int Bedrag //no features
        {
            get
            {
                return _bedraag;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("bedraag must be > 0");
                    return;
                }
                //int futureBedrag = value;
                //if (futureBedrag < 0)
                //{
                //    Console.WriteLine("bedraag must be > 0");
                //    return;
                //}
                ////int futureBedrag = value; //smth we will give into
                //_bedraag = futureBedrag;

                _bedraag = value; // a key word for input parameter
            }
        }

    }
}
