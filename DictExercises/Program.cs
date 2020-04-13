using System;
using System.Collections.Generic;

namespace DictExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> enemiesPerAnimal = new Dictionary<string, int>();
            enemiesPerAnimal.Add("Hond", 5);
            enemiesPerAnimal.Add("Kat", 3);
            enemiesPerAnimal.Add("Zeemeermin", 99);
            enemiesPerAnimal.Add("Beer", 9);
            enemiesPerAnimal.Add("Leeuw", 11);
            Console.WriteLine("Before:");
            enemiesPerAnimal.PrintDict();

            Console.WriteLine();
            
                enemiesPerAnimal.Remove("Zeemeermin");
            Console.WriteLine("After:");

            enemiesPerAnimal.PrintDict();
        }
    }
    
   

    public static class ExtensionMethods
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
