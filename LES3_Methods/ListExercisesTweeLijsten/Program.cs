using System;
using System.Collections.Generic;



namespace ListExercisesTweeLijsten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namen1 = new List<string>();
            List<string> namen2 = new List<string>();
            putIntoList(namen1);
            putIntoList(namen2);

            namen2.AddRange(namen1);


            PrintList(namen2);

        }
        public static void putIntoList(List<string> l)
        {
            l.Add("Ciara");
            l.Add("Katrina");
            l.Add("Elena");
            return;
        }

        public static void PrintList(List<string> l)
        {
            foreach (string elem in l)
            {
                Console.Write(elem + " ");
            }
            return;
        }

    }
}
