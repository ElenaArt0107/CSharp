using System;

namespace _8._14_Try_Parse_Integer_Custom_Error_Message
{
    class Program

    {
        
        static void Main(string[] args)
        {
            Console.WriteLine($"Geef custom error voor het verkeerd parsen van een integer:");
            string customError = Console.ReadLine();
            int getaal = GetGetal(customError);
            Console.WriteLine($"Je ingegeven getal is: {getaal}");


        }
        static int GetGetal(string customError)
        {
            Console.WriteLine("Geef een getal in:");
            string input = Console.ReadLine();
            int getaal;
            while (!int.TryParse(input, out getaal))
            {
                Console.WriteLine(customError);
                Console.WriteLine("Geef een getal in:");
                input = Console.ReadLine();
            }
            return getaal;
        }
    }
}
