using System;

namespace ClassesGettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //AutoM1 a = new AutoM1("BMW", ConsoleColor.Black, 2);
            //a.SetHuidigeVersnelling(-1);
            //a.SetHuidigeVersnelling(1);
            //a.SetHuidigeVersnelling(30);

            //Console.WriteLine(a.GetHuidigeVersnelling());

            //a.Info();

            ////oef 2

            //RekkeningM2 r = new RekkeningM2("Marijke", 5000);
            //string naam = r.Naam;
            //int bedraag = r.Bedrag;
            //Console.WriteLine($"Naam: {naam} and bedraag is {bedraag}");

            //r.Naam = "Brand";
            //r.Bedrag = -124;
            //r.Bedrag = 124;
            //Console.WriteLine(r.Bedrag);

            // oef3

            AutoM2 a = new AutoM2("Alpha", ConsoleColor.Gray, 275);
            string merk = a.Merk;
            string colour = a.Kleur.ToString();
            double versnelling = a.MaxVersnelling;
            double versnellingHuidige = a.HuidigeVersnelling;

            a.Info();
            Console.WriteLine();

            a.Merk = "Ferreri";
            a.Kleur = ConsoleColor.Red;
            a.MaxVersnelling = 500;
            a.HuidigeVersnelling = 505;
            a.HuidigeVersnelling = 120;

            a.Info();






        }
    }
}
