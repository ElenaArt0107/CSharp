using System;
using System.Collections.Generic;

namespace DictEx2Rugzakken
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rugzakPauline =new Dictionary<string, int>();
            Dictionary<string, int> rugzakKaren = new Dictionary<string, int>();
            int som = 0;

            rugzakPauline.Add("Zaklamp", 1);
            rugzakPauline.Add("Beschuitjes", 6);
            rugzakPauline.Add("Water", 12);

            rugzakKaren.Add("Picknickmand", 1);
            rugzakKaren.Add("Kaart", 1);
            rugzakKaren.Add("Beschuitjes", 6);
            rugzakKaren.Add("Water", 6);

            int quantityP = CountItemsInDict(rugzakPauline);
            int quantityK =  CountItemsInDict(rugzakKaren);

            Console.WriteLine($"Paulina heeft {quantityP} items en Karen heeft {quantityK}");

        }
        public static int CountItemsInDict <Tkey, Tvalue>(Dictionary<Tkey, Tvalue> a)
        {
            int som = 0;
            foreach (var item in a)
            {
                int quantity = Convert.ToInt32(item.Value);
                som += quantity;
            }

            return som;
        }

    }
}
