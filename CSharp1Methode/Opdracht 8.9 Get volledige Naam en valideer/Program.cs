using System;

namespace Opdracht_8._9_Get_volledige_Naam_en_valideer
{
    class Program
    {
        private const string VoornaamNietGegeven = "Voornaam is niet opgegeven";
        private const string FamilieNaamNietGegeven = "FamilieNaam is niet opgegeven";

        static void Main(string[] args)
        {
            string naam = GetAndValidateVolledigeNaam();
            if (naam.Contains(VoornaamNietGegeven)) 
            {
                Console.WriteLine(VoornaamNietGegeven);
            }
            else if (naam.Contains(FamilieNaamNietGegeven))
            {
                Console.WriteLine(FamilieNaamNietGegeven);
            }
            else
            {
                Console.WriteLine(naam);
            }
        }

        static string GetAndValidateVolledigeNaam()
        {
            Console.WriteLine("Geef je voornaam aub:");

            string vn = Console.ReadLine();

           
            if (IsStringLeeg(vn))
            {
                vn = VoornaamNietGegeven;
                // return returns value and stopm the programm

            }



            Console.WriteLine("Geef je familiennaam aub:");

            string fn = Console.ReadLine();
            if (IsStringLeeg(fn))
            {
                fn = FamilieNaamNietGegeven;
            }

            string volledigeNaam = GetVolledigNaam(vn, fn);
            return volledigeNaam;
        }
        static bool IsStringLeeg(string input)
        {
            if (string.IsNullOrWhiteSpace(input) == true)
            {

                return true;
            }
            else
            {
                return false;
            }


        }
        static string GetVolledigNaam(string vn, string fn)
        {
           string VolledigNaam = vn + ' ' + fn;

           return VolledigNaam;
        }
    }
}
