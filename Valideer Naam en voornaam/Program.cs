using System;

namespace Valideer_Naam_en_voornaam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je voornaam aub:");

            string vn = Console.ReadLine();
            if (IsStringLeeg(vn))
            {
                Console.WriteLine("Voornaam is niet opgegeven");
                return;
            }

            Console.WriteLine("Geef je familiennaam aub:");

            string fn = Console.ReadLine();
            if (IsStringLeeg(fn))
            {
                Console.WriteLine("Familienaam is niet opgegeven");
                return;
            }
            Console.WriteLine("zowel de voornaam als famileinaam zijn inguvld.");
        }
        static bool IsStringLeeg(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

    }
}
