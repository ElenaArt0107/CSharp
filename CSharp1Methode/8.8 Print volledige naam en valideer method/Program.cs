using System;

namespace _8._8_Print_volledige_naam_en_valideer_method
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEnValideerVolledigeNaam();     //the method has been written without input values
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
        static void printVolledigNaam(string vn, string fn)
        {
            string VolledigNaam = vn + ' ' + fn;

            Console.WriteLine(VolledigNaam);
        }
        static void PrintEnValideerVolledigeNaam()       //the method has been written without input values
        {
            Console.WriteLine("Geef je voornaam aub:");

            string vn = Console.ReadLine();
            if (IsStringLeeg(vn))
            {
                Console.WriteLine("Voornaam is niet opgegeven");
                return;  // return returns value and stopm the programm
            }



            Console.WriteLine("Geef je familiennaam aub:");

            string fn = Console.ReadLine();
            if (IsStringLeeg(fn))
            {
                Console.WriteLine("Familienaam is niet opgegeven");
                return;
            }


            Console.WriteLine("zowel de voornaam als famileinaam zijn inguvld.");

            printVolledigNaam(vn, fn);
        }

    }
}
