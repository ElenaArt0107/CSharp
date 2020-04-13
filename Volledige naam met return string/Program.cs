using System;

namespace Volledige_naam_met_return_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je voornaam aub:");

            string vn = Console.ReadLine();

            Console.WriteLine("Geef je voornaam aub:");

            string fn = Console.ReadLine();
            string VolledigNaam = GetVolledigNaam(vn, fn);

            Console.WriteLine(VolledigNaam);
        }
        static string GetVolledigNaam(string voornaam, string familienaam)
        {
            string naam = voornaam + ' ' + familienaam;
            return naam;
        }
    }
}
