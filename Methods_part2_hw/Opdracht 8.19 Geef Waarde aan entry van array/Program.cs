using System;

namespace Opdracht_8._19_Geef_Waarde_aan_entry_van_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int indexTeVeranderen;
            int waardeTeVerandern;
            int[] getalen = new int[length];
            string welkeIndex = "Welke index wil je veranderen?";
            string welkeWaarde = "Naar welke waarde toe wil je veranderen?";

            MaakArray(getalen, length);

            Console.WriteLine("BEFORE");
            PrintArray(getalen);

            indexTeVeranderen = GetGetal(welkeIndex);
            waardeTeVerandern = GetGetal(welkeWaarde);

            ChangeEntryArray(getalen, indexTeVeranderen, waardeTeVerandern);
          
            Console.WriteLine("AFTER");
            PrintArray(getalen);

        }
        static int GetGetal(string question)
        {
            Console.WriteLine(question);
            string input = Console.ReadLine();
            int getaal;
            while (!int.TryParse(input, out getaal))
            {
                Console.WriteLine("Je gaf een verkeerde waarde, probier opnieuw");
                Console.WriteLine(question);
                Console.WriteLine("Geef een getal in:");
                input = Console.ReadLine();
            }
            return getaal;
        }
        static void MaakArray(int[] getalen, int length, int waarde = 99)
        {
            for (int i = 0; i < length; i++)
            {
                getalen[i] = waarde;
            }
        }
        static void PrintArray(int[] array)
        {
            string a = "Printing Array";
            int lettersInFirstWord = a.Substring(a.IndexOf(' ')).Length + 1;
            Console.WriteLine(a);
            for (int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l <= lettersInFirstWord; l++)
                {
                    Console.Write(' ');
                }
                Console.Write(array[i]);
                Console.WriteLine();
            }
        }
        static bool NumberBetweenTwoValues(int numberToCheck, int min, int max)
        {
            if (numberToCheck >= min && numberToCheck <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void ChangeEntryArray(int[] array, int changeIndex, int value)
        {
            int min = 0;
            int max = array.Length;

           if (NumberBetweenTwoValues(changeIndex, min, max) == true)
            {
                array[changeIndex] = value;
                return;
            }
           else
            {
                Console.WriteLine($"De ingegeven index {value} moet leggen tussen {min} en {max}");
                return;
            }
        }
    }
}
