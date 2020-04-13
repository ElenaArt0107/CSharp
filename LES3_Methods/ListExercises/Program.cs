using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            List<decimal> kassaBijhoudt = new List<decimal>();

            for (int i = 0; i < 6; i++)
            {
                kassaBijhoudt.Add(rnd.Next(-100, 100));
            }
            Console.WriteLine("Before:");
            Console.WriteLine();
            PrintListForEach(kassaBijhoudt);
            Console.WriteLine();

            kassaBijhoudt.Sort();
            kassaBijhoudt.Reverse();
            kassaBijhoudt.Remove(kassaBijhoudt[1]);

            Console.WriteLine("After:");
            Console.WriteLine();
            PrintListForEach(kassaBijhoudt);


        }
        public static void PrintListForEach(List<decimal> l)
        {
            foreach (decimal getaal in l)
            {
                Console.Write(getaal + " ");
            }
            return;
        }
    }
}
