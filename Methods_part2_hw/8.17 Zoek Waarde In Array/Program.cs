using System;

namespace _8._17_Zoek_Waarde_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getalen = { 2, 8, 7, 15, 16 };
            int teZoekenWaarde = GetGetal();
            int indexVanGezochteWaade = GeefIndexVankWaardeInArray(getalen, teZoekenWaarde);
            if (indexVanGezochteWaade >= 0)
            {
                Console.WriteLine($"De index van de waarde {teZoekenWaarde} is : {indexVanGezochteWaade}");
            }
            else
            {
                Console.WriteLine($"De waarde {teZoekenWaarde} bestaat niet in de array");
            }

        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine("Printing Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("        " + array[i]);
            }
        }
        static int GetGetal()
        {
            Console.WriteLine("Rat het getaal: ");
            string input = Console.ReadLine();
            int getaal;
            while (!int.TryParse(input, out getaal))
            {
                Console.WriteLine("Je gaf een verkeerde waarde, probier opnieuw");
                Console.WriteLine("Rat het getaal!");
                Console.WriteLine("Geef een getaal in:");
                input = Console.ReadLine();
            }
            return getaal;
        }
        static int GeefIndexVankWaardeInArray(int[] array, int teZoekenWaarde)
        {
            PrintArray(array);
            int index;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == teZoekenWaarde)
                {
                    index = i;
                    return index;
                }
            }
            return -1;

        }
    }
    
}
