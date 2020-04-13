using System;

namespace _8._11_Print_lijn_met_zelf_gekozen_karakter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoelang moet je lijn zijn?");
            int lengte = int.Parse(Console.ReadLine());
            Console.WriteLine("welke karakter wil je gebruiken?");
            char karakter = char.Parse(Console.ReadLine());
            TrekLijn(lengte, karakter);
        }
        static void TrekLijn(int lengte, char karakter)
        {
            for (int i = 0; i < lengte; i++)
            {
                Console.Write(karakter);
            }
        }
    }
}
