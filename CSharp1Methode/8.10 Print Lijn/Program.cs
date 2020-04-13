using System;

namespace _8._10_Print_Lijn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoelang moet je lijn zijn?");
            int lengte = int.Parse(Console.ReadLine());
            TrekLijn(lengte);
        }
        static void TrekLijn(int lengte)
        {
            for (int i = 0; i < lengte; i++)
            {
                Console.Write('_');
            }
        }
    }
}
