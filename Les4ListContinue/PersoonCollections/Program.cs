using System;
using System.Collections.Generic;


namespace PersoonCollections
{
    //public const int ClantenInDeRey = 5;

    class Person
    {
        public string naam;
        public decimal bedrag;

        public Person(string naam, decimal bedrag)
        {
            this.naam = naam;
            this.bedrag = bedrag;
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> klanten = new Queue<Person>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Customer card, ");
                string naam = Console.ReadLine();

                Console.WriteLine("Zo viel cents");
                decimal bedrag = decimal.Parse(Console.ReadLine());

                Person klant = new Person(naam, bedrag);
                klanten.Enqueue(klant);
            }

            decimal totalKassa = 0;

            while (klanten.Count> 0)
            {
                Person klant = klanten.Dequeue();
                Console.WriteLine($"Klant {klant.naam} heeft for {klant.bedrag} angekocht");
                totalKassa += klant.bedrag;
                if (klant.bedrag <= 0)
                {
                    klanten.Enqueue(klant);

                    klant.bedrag *= -1 ;
                    continue;
                }
            }

            Console.WriteLine($"Totaal kassa: {totalKassa}");
        }
    }
}
