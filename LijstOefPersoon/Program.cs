using System;
using System.Collections.Generic;

using Person;

namespace LijstOefPersoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> people = new List<Persoon>();
            Persoon dimi = new Persoon("Dimi", "Nelo");
            Persoon ele = new Persoon("Elen", "Art");
            Persoon lia = new Persoon("Lia", "Nelo");

            people.Add(dimi);
            people.Add(ele);
            people.Add(lia);

            PrintList(people);
            Console.WriteLine();
        }

        public static void PrintList(List<Persoon> l)
        {
            foreach (Persoon p in l)
            {
                p.Descript();
                Console.Write("; ");
            }
            return;
        }
    }
}
