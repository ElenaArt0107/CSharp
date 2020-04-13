using System;
using System.Collections.Generic;


namespace Exercise2Collections
{
    public class Familie
    {
        public int aantalVolwassenen;
        public int aantalKinderen;
        public string familienaam;

        public Familie(int aantalVolwassenen, int aantalKinderen, string familienaam)
        {
            this.aantalVolwassenen = aantalVolwassenen;
            this.aantalKinderen = aantalKinderen;
            this.familienaam = familienaam;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal volwassenenBedrag = 20;
            decimal kinderenBedrag = 15;
            decimal totaalBedrag = 0;
            string familienaam;
            int aantalKinderen;
            int aantalVolwassenen;

            Queue<Familie> pretparkRij = new Queue<Familie>();

            do
            {

                Console.WriteLine("Jouw Naam: ");
                familienaam = Console.ReadLine();


                Console.WriteLine("Hoeveel kinderen: ");
                aantalKinderen = int.Parse(Console.ReadLine());


                Console.WriteLine("Hoeveel Volwassenen: ");
                aantalVolwassenen = int.Parse(Console.ReadLine());

                Familie familie = new Familie(aantalKinderen, aantalVolwassenen, familienaam);

                pretparkRij.Enqueue(familie);

            }
            while (Console.ReadLine() != "stop");
            

            foreach (Familie familie in pretparkRij)
            {
                pretparkRij.Dequeue();
                decimal somKind  = familie.aantalKinderen * kinderenBedrag;
                decimal somVolw = familie.aantalVolwassenen * volwassenenBedrag;
                string naam = familie.familienaam;
                totaalBedrag = somKind + somVolw;
                Console.WriteLine($"Familie: {naam}. Total bedraag: {totaalBedrag} ");

            }
        }
    }
}
