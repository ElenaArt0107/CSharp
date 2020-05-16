using System;

namespace abstractExerciseLes
{
    class Program
    {
        static void Main(string[] args)
        {
            Whale w = new Whale();
            w.Name = "Whale";

            Console.WriteLine(w.Name);
            Console.WriteLine(w.Sort);
            w.MakeSound();
            Console.WriteLine();
            Console.WriteLine("========================");
            Goldfish g = new Goldfish();
            g.Name = "Goldfish";

            Console.WriteLine(g.Name);
            Console.WriteLine(g.Sort);
            g.MakeSound();
            Console.WriteLine( );
            Console.WriteLine("========================");

            Rododendron r = new Rododendron();
            r.Name = "Rododendron";
            Console.WriteLine(r.Name);
            Console.WriteLine(r.Sort);
            Console.WriteLine(r.Color);
            Console.WriteLine();
            Console.WriteLine("========================");




        }
    }
}
