using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> woorden = new List<string>();
            List<string> omschrijving = new List<string>();

            /*
             * woorden.Add("lezen");
            woorden.Add("");
            woorden.Add("drinken");

            omschrijving.Add("");
            omschrijving.Add("");
            omschrijving.Add("");
            */

            // diffirence between list and dictionary: in list<T>/queue/array the index is an int, but dictionary can have the index with different datatypes

            ////////////////////////// dictionary : using System.Collections.Generic; ////////////////////////////
            /// have 2 parameters: Tkey (datatepe of index) and Tvalue - 'T' means type of the values
            Dictionary<string, string> woordenbook = new Dictionary<string, string>();

            /*
            Dictionary<string, decimal> bedraagenPerPerson; //Declaration only
            Dictionary<Staad, Weer> weerPerStaad; //the types are the classes
            Dictionary<Functie, decimal> bedraagenPerPerson; //a class Functie as an index and a 'normal' type decimal
            */

            woordenbook.Add("leren","...");
            woordenbook.Add("vergeten", "___");
            //woordenbook.Add("vergeten", "xxx"); //- will give an exception
            woordenbook.Add("Snoep", "Yuppi!!!");

            string key = "Snoep";
            string value = "Yamie!!!";
            ////////////////////////////// to put in the dictionary avoiding the violance of a key
            ///
            Console.WriteLine("A key must be unique:");
            Console.WriteLine();
            if (woordenbook.ContainsKey(key))
            {
                Console.WriteLine($"Sorry, {key} bestaat al :(");
            }
            else
            {
                woordenbook.Add(key, value);

            }
            Console.WriteLine(woordenbook[key]); // will print the current value
            Console.WriteLine();
            /////////////////////////// change the value///////////////////////
            ///
            Console.WriteLine("change the value:");
            Console.WriteLine();

            Console.WriteLine("Before:");
            Console.WriteLine(woordenbook["leren"]);

            Console.WriteLine();
            Console.WriteLine("After:");
            woordenbook["leren"] = "Leren is niet meer leuk";
            Console.WriteLine( woordenbook["leren"]);
            Console.WriteLine();

            ///////////////////////////////// to print out a dict : ///////////////////////////
            ///
            Console.WriteLine("to print out a dict");
            Console.WriteLine();

            foreach (var item in woordenbook)
            {
                string woord = item.Key;
                string omschrijving1 = item.Value;
                Console.WriteLine($"{woord}: {omschrijving1}");
            }
        }
    }
}
