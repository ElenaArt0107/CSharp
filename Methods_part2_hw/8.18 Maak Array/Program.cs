using System;

namespace _8._18_Maak_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayLengte = "Geef de lengte van je array:";
            string arrayDefaultWaarde = "Geef de defaultWaarde van je array:";

            int lengte = GetGetal(arrayLengte);
            int defaultWaarde = GetGetal(arrayDefaultWaarde);

            int[] arrayVanGebruiker = MaakArray(lengte, defaultWaarde);

            PrintArray(arrayVanGebruiker);

        }
        static int GetGetal(string aanvraag)
        {
            Console.WriteLine(aanvraag);
            string input = Console.ReadLine();
            int getaal;
            while (!int.TryParse(input, out getaal))
            {
                Console.WriteLine("Je gaf een verkeerde waarde, probier opnieuw");
                Console.WriteLine(aanvraag);
                input = Console.ReadLine();
            }
            return getaal;
        }
        static int[] MaakArray(int lengte, int defaultWaarde = 0)
        {
            int[] array = new int[lengte];
            for (int i = 0; i < lengte; i++)
            {
                array[i] = defaultWaarde;
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine("Printing Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("        " + array[i]);
            }
        }
    }
}
