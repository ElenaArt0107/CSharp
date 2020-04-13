using System;
using System.Collections.Generic;


namespace RelationOne2Many
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 to * relationship
            //
            // firs option:
            Auto auto1 = new Auto("BMW", "black");


            Passagier p1 = new Passagier("Dimi N", 29);
            Passagier p2 = new Passagier("Pasha K", 30);


            // 
            auto1.AddPasagier(p1);
            auto1.AddPasagier(p2);




            // 2nd option:
            Passagier p3 = new Passagier("Tan", 30);
            Passagier p4 = new Passagier("Ele", 29);

            List<Passagier> passagiers = new List<Passagier>();
            passagiers.Add(p3);
            passagiers.Add(p4);

            Auto auto2 = new Auto("Alfa Romeo 4verde", "brown", passagiers);

            //INFO:

            auto1.Info();
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            auto2.Info();


        }
    }
}

