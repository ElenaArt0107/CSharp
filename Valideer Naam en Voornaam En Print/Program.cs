using System;

namespace Valideer_Naam_en_Voornaam_En_Print
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
        static bool IsStringLeeg(string input)
        {
            if (string.IsNullOrWhiteSpace(input) == true)
            {

                return true; // if we use not void but the exact datatype value with a function, after  return   we should put a value of the same datatype;
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
    
    }
}
