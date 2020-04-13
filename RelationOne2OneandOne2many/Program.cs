using System;

namespace RelationOne2OneandOne2many
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////// oefening 1-1 relation
            ///


            //4. Maak twee auto’s aan met elk hun eigen passagier:
            Auto auto1 = new Auto("BMW", "black", "Pasha K", 30);

            Passagier dimi = new Passagier("Dimi N", 29);
            Auto auto2 = new Auto("Alfa Romeo 4verde", "brown", dimi);


            // 5. Toon het resultaat in de console dmv de Info method

            auto1.Info();
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            auto2.Info();


        }
    }
}
