using System;

namespace Valideer_op_een_lege_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je lievelingsdier in:");
            string lievelingsdier = Console.ReadLine();

            string output = IsStringLeeg(lievelingsdier);
            Console.WriteLine(output);
        }

        static string IsStringLeeg (string input)
        {
            if (string.IsNullOrEmpty(input) == true)
            {
                return "Je heef geen lievelingsdier opgegeven";
            }
            else
            {
                return "Je lievelingsdier is: " + input;
            }
        }
    }
}
