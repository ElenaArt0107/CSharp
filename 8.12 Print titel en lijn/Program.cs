using System;

namespace _8._12_Print_titel_en_lijn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welke is je lievelingsplaneet ");
            string planeet = Console.ReadLine();
            if (IsStringLeeg(planeet))
            {
                Console.WriteLine("lievelingsplaneet is niet opgegeven");
                return;  // return returns value and stop the VOID METHOD (if it's void main obviously it'll stop the programm also)
            }
            char karakter = '_';

            TrekLijn(planeet, karakter);
        }
        static bool IsStringLeeg(string input)
        {
            return string.IsNullOrWhiteSpace(input); // if we use not void but the exact datatype value with a function, 
            //after  return   we should put a value of the same datatype;
        }

        static void TrekLijn(string input, char karakter)
        {
            Console.WriteLine();
            Console.WriteLine(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(karakter);
            }
        }
    }
}
