using System;

namespace _8._15_Som_Punten_en_Check_De_punten_met_de_GetGetal_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int getaal;
            int som = 0;
            for (int i = 0; i < 5; i++)
            {
                getaal = GetGetal(i+1);
                som += getaal;
            }
            
            Console.WriteLine($"De som is: {som}");
        }
        static int GetGetal(int getalNummer)
        {
            Console.WriteLine($"Geef een getal {getalNummer}e in:");
            string input = Console.ReadLine();
            int getaal = int.Parse(input);
            while (!int.TryParse(input, out getaal))
            {
                Console.WriteLine("Je gaf een verkeerde waarde, probier opnieuw");
                Console.WriteLine("Geef een getal in:");
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
