using System;

namespace SyntraWestExamenCSharpOlenaArtiushenko20192020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hoe viel kinderen kunnen in de rij staan?");
            int arrayLength = int.Parse(Console.ReadLine());

            if (arrayLength <= 0)
            {
                do
                {
                    Console.WriteLine("Die rij moet groter dan 0 zijn");
                    arrayLength = int.Parse(Console.ReadLine());
                }
                while (arrayLength <= 0);
            }

            decimal gemiddelde, sum = 0, aantal = 0;
            decimal gemiddelde1 = 0, sum1 = 0, aantal1 = 0;
            decimal gemiddelde2 = 0, sum2 = 0, aantal2 = 0;

            string[] kindNaam = new string[arrayLength];
            string[] kindSpeelgoedNaam = new string[arrayLength];
            decimal[] kindSpeelgoedPrijs = new decimal[arrayLength];

            // gethering info from kids

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Geef de naam voor de kind {i + 1}");
                kindNaam[i] = Console.ReadLine();

                if (String.IsNullOrEmpty(kindNaam[i]) || String.IsNullOrWhiteSpace(kindNaam[i]))
                // the other option can be a check via length of the string input  (as a string is an array of chars) if it's less/equal 0, but it won't work for spaces
                {
                    do
                    {
                        Console.WriteLine("De naam moet niet leeg zijn, probeer opnieuw");
                        kindNaam[i] = Console.ReadLine();
                    }
                    while (String.IsNullOrEmpty(kindNaam[i]) || String.IsNullOrWhiteSpace(kindNaam[i]));
                }
                
                Console.WriteLine($"Geef de naam voor de speelgoed voor {kindNaam[i]}");
                kindSpeelgoedNaam[i] = Console.ReadLine();

                if (String.IsNullOrEmpty(kindSpeelgoedNaam[i]) || String.IsNullOrWhiteSpace(kindSpeelgoedNaam[i]))
                {
                    do
                    {
                        Console.WriteLine("De naam van het speelgoed moet niet leeg zijn, probeer opnieuw");
                        kindSpeelgoedNaam[i] = Console.ReadLine();
                    }
                    while (String.IsNullOrEmpty(kindSpeelgoedNaam[i]) || String.IsNullOrWhiteSpace(kindSpeelgoedNaam[i]));
                }

                Console.WriteLine($"Wat is de prijs voor een {kindSpeelgoedNaam[i]}");
                kindSpeelgoedPrijs[i] = decimal.Parse(Console.ReadLine());

                if (kindSpeelgoedPrijs[i] <= 0)
                {
                    do
                    {
                        Console.WriteLine("De prijs van het speelgoed moet groter dan 0 zijn, probeer opnieuw");
                        kindSpeelgoedPrijs[i] = decimal.Parse(Console.ReadLine());
                    }
                    while (kindSpeelgoedPrijs[i] <= 0);
                }
                sum += kindSpeelgoedPrijs[i];
                aantal++;
            }
            gemiddelde = sum / aantal;

            // loop over prices to put them in the loop of goedkoop first 3.a.i in an exam task
            string[] goedkoop = new string[arrayLength];
            string[] duur = new string[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                goedkoop[i] = "LEEG";
                duur[i] = "LEEG";
            }

            //loop over prices to divide into two arrays
            for (int i = 0; i < arrayLength; i++)
            {

                if (kindSpeelgoedPrijs[i] < gemiddelde)
                {
                    for (int l = 0; l < i+1; l++)
                    {
                        if (goedkoop[l] == "LEEG")
                        {
                            goedkoop[l] = $"{kindNaam[i]} | {kindSpeelgoedNaam[i]}";
                            break;
                        }
                    }
                    sum1 += kindSpeelgoedPrijs[i];
                    aantal1++;
                }
             
                if (kindSpeelgoedPrijs[i] >= gemiddelde)
                {
                    for (int l = 0; l < i+1; l++)
                    {
                        if (duur[l] == "LEEG")
                        {
                            duur[l] = $"{kindNaam[i]} | {kindSpeelgoedNaam[i]}";
                            break;
                        }
                    }
                    sum2 += kindSpeelgoedPrijs[i];
                    aantal2++;
                }
            }

            string speelgood = "DUUR SPEELGOED";
            int index1 = 0;
            try
            {
                gemiddelde1 = sum1 / aantal1;
            }
            catch (System.DivideByZeroException) { }

            try
            {
                gemiddelde2 = sum2 / aantal2;
            }
            catch (System.DivideByZeroException) { }
                       
            
            // output
            Console.WriteLine();
            speelgood = "GOEDKOOP SPEELGOED";
            Console.WriteLine(speelgood);

            for (int i = 0; i < speelgood.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            index1 = 0;
            

            for (int i = 0; i < arrayLength; i++)
            {
                if (goedkoop[i] != "LEEG")
                {
                    index1 = goedkoop[i].IndexOf('|');
                    Console.WriteLine($"{goedkoop[i].Substring(0, index1)}will graag een {goedkoop[i].Substring(index1 + 2)}");
                }
            }
            
            Console.WriteLine($"aantal: {aantal1}, gemiddelde: {gemiddelde1}");
            Console.WriteLine();

            speelgood = "DUUR SPEELGOED";
            Console.WriteLine(speelgood);
            
            for (int i = 0; i < speelgood.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            
            for (int i = 0; i < arrayLength; i++)
            {
                if (duur[i] != "LEEG")
                {
                    index1 = duur[i].IndexOf('|');
                    Console.WriteLine($"{duur[i].Substring(0, index1)}will graag een {duur[i].Substring(index1 + 2)}");
                }
            }
            Console.WriteLine($"aantal: {aantal2}, gemiddelde: {gemiddelde2}");

        }
    }
}
