using System;
using System.Collections.Generic;

namespace DictEx1Magazijn
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> magazijn = new Dictionary<string, int>();
            string article, inMagazijn = "Artikelen in het magazijn stoppen", outPrint = "magazijn uitlezen";
            int quantity;

            lowerDashPrint(inMagazijn);
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Waat voor artikel zit in magazijn");
                article = Console.ReadLine();
                Console.WriteLine($"Hoe viel {article} zitten in magazijn");
                quantity = int.Parse(Console.ReadLine());

                magazijn.Add(article, quantity);
            }
            Console.WriteLine();

            lowerDashPrint(outPrint);

            magazijn.PrintDict();

        }
        public static void lowerDashPrint(string text)
        {
            Console.WriteLine(text);
            for (int i = 0; i < text.Length / 2; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
            Console.WriteLine();

            return;
        }
    }
    public static class ExtensionMethods // for lists , dicts, arrays...
    {
        public static void PrintDict<Tkey, Tvalue>(this Dictionary<Tkey, Tvalue> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            return;
        }
    }
   
}

