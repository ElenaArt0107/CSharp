using System;
using System.Collections.Generic;

namespace One2ManyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 to * relationship
            //Één waarbij je de naam en de Geboortedatum van de Persoon vraagt

            Huisdier pet1 = new Huisdier("Emy", "Dog");
            Huisdier pet2 = new Huisdier("Lao", "Monkey");

            Persoon p1 = new Persoon("Dimi", new DateTime(1990, 07, 22));
            p1.AddPet(pet1);
            p1.AddPet(pet2);



            //Tweede waarbij Geboortedatum van de Persoon vraagt EN een lijst met huisdieren
            Huisdier pet3 = new Huisdier("Tao", "Cat");
            Huisdier pet4 = new Huisdier("Like", "BigCat");

            List<Huisdier> huisdierenLocalClass = new List<Huisdier>();
            huisdierenLocalClass.Add(pet3);
            huisdierenLocalClass.Add(pet4);

            Persoon p2 = new Persoon("Ele", new DateTime(1990, 07, 01), huisdierenLocalClass);

            //INFO:
            p1.Info();
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine();
            p2.Info();



        }
    }
}
