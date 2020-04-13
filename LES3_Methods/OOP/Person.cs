using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        public string voornaam;
        public string familiennaam;

        public void Descript()
        {
            Console.WriteLine(voornaam + " " + familiennaam);
        }

        public Person(string voornaamI, string familiennaamI)
        {
            voornaam = voornaamI;
            familiennaam = familiennaamI;
        }
    }
}
