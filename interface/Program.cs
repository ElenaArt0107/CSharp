using System;
using System.Collections.Generic;

namespace Abstract1
{
    class Program
{
    static void Main(string[] args)
    {
            // Oefening o = new Oefening() //is not possible to create instance from the abstract class,
            // but you can only inherit it, and only once in comparison with interface - you can inherit several interfaces

            Random rnd = new Random();

            OefeningOptellenOnder10 ex1 = new OefeningOptellenOnder10("Som", rnd); // class is not abstract, instance is possible to create
            ExcersiceExtractUnder10 ex2 = new ExcersiceExtractUnder10("Deduction", rnd);

            List<Oefening> exercises = new List<Oefening>();
            exercises.Add(ex1);
            exercises.Add(ex2);
            exercises.Add(ex1);
            exercises.Add(ex2);
            foreach (var item in exercises)
            {
                Console.WriteLine(item.Naam);
                Console.WriteLine("================");
                Console.WriteLine();
                item.GenereerOefening();
                Console.WriteLine(item.Vraag); // not a method just a parameter
                item.Aantwoord = int.Parse(Console.ReadLine());
                if (item.IsCorrectGeantwoord())
                {
                    Console.WriteLine("correct!");
                }
                else
                {
                    Console.WriteLine("Good luck next time");
                    Console.WriteLine($"Your abwer is {item.Aantwoord}. Correct answer is {item.Oplossing}");
                }
            }


        }
    }
}
