using System;
//using ProgrammMemoryStorage;
using System.Collections.Generic;

namespace ProgrammMemoryStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            // the connection 1-1 and 1-*  via the coding in C#
            
            // 1-1 relation
            // Persoon 1

            Personen persoon1 = new Personen("Carl Orph", new DateTime(1895, 07, 10), "Cher Ami", "Duif");

            // Persoon 2
            Huisdieren h = new Huisdieren("Huisdieren", "Hond");

            Personen persoon2 = new Personen("A Gitlee", new DateTime(1889, 4, 20), h);

            // INFO

            persoon1.Info();
            Console.WriteLine("--------------------------");
            persoon2.Info();

            // getters and setters
        }
    }
}
