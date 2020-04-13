using System;
using System.Collections.Generic;
using System.Text;

namespace TransactiesMetClass
{
    class Transactie
    {
        public string naam;
        public decimal bedrag;

        public Transactie(string n, decimal b)
        {
            naam = n;
            bedrag = b;
        }
    }
}
