using System;

namespace VolledigeNaam
{
    class Program
    {
        static void Main(string[] args)
        {
            GetVolledigNaam();

        }
        static void GetVolledigNaam()
        {
            Console.WriteLine("Geef je voornaam aub:");

            string vn = Console.ReadLine();

            Console.WriteLine("Geef je voornaam aub:");

            string fn = Console.ReadLine();

            string VolledigNaam = vn + ' ' + fn;

            Console.WriteLine(VolledigNaam);
        }
    }
}
