using System;

namespace Volledige_naam_Vraag_Naam_en_voornaam_in_method_en_return
{
    class Program
    {
         static void Main(string[] args)
        {
            string volledigNaam = GetVolledigNaam();
            Console.WriteLine(volledigNaam);
        }
        static string GetVolledigNaam()
        {
            Console.WriteLine("Geef je voornaam aub:");

            string vn = Console.ReadLine();

            Console.WriteLine("Geef je voornaam aub:");

            string fn = Console.ReadLine();

            string VolledigNaam = vn + ' ' + fn;
            Console.WriteLine(VolledigNaam);
            
            return VolledigNaam;
        }
     }
}
