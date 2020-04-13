using System;

namespace _8._13_Try_Parse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {

            int getaal = GetGetal();
            Console.WriteLine($"Je ingegeven getal is: {getaal}");


        }
        static int GetGetal()
        {
            Console.WriteLine("Geef een getal in:");
            string input = Console.ReadLine();
            int getaal;
            while (!int.TryParse(input, out getaal))
            {
                Console.WriteLine("Je gaf een verkeerde waarde, probier opnieuw");
                Console.WriteLine("Geef een getal in:");
                input = Console.ReadLine();
            }
            return getaal;
        }
    }
}
