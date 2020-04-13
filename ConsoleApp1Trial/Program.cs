using System;

namespace ConsoleApp1Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] goedkoop = { "el | ball", "lwe | doll", "LEEG" };
            int index1 = 0;
            for (int i = 0; i < 3; i++)
            {
                if (goedkoop[i] != "LEEG")
                {
                    index1 = goedkoop[i].IndexOf('|');
                    Console.WriteLine($"{goedkoop[i].Substring(0, index1)}will graag een {goedkoop[i].Substring(index1 + 2)}");
                }
            }



        }
    }
}
