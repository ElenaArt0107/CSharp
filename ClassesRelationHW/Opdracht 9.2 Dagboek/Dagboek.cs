using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_9._2_Dagboek
{
    class Dagboek
    {
        public List<string> pages;

        public Dagboek ()
        {
            pages = new List<string>();
        }
        public void SchrijfNieuwePagina()
        {
            Console.WriteLine("Schrijf een nieuwe text:");
            string page = Console.ReadLine();
            pages.Add(page);
            Console.WriteLine();
        }
        public void PrintBoek()
        {
            int i = 0;
            foreach (var page in pages)
            {
                i ++;
                Console.WriteLine($"Pagina # {i}/{pages.Count}");
                Console.WriteLine(page);
                Console.WriteLine();
            }
        }
    }


}
