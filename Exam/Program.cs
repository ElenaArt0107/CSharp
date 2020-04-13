using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength;
            string dna = "DNA";
            string codons = "Codons";

            Console.WriteLine("Hoe lang moet je DNA zijn?");

            try
            {
                dnaLength = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                string exception = "Er liept its fout bij het inlezen van de length.\nProbier maar opniuew";

                Console.WriteLine(exception);
                return;
            }

            if (dnaLength % 3 != 0)
            {
                string otherValue = "Het moet een positief getal zijn\nen het moet een veelvoud van drie zijn";
                Console.WriteLine(otherValue);
            }

            else
            {
                char[] dnaString = new char[dnaLength];
                char[] dnaStringRight = new char[dnaLength];
                char[] dnaBase = { 'A', 'T', 'C', 'G' };

                for (int i = 0; i < dnaLength; i++)
                {
                    Random rand = new Random();
                    int rnd = rand.Next(0, 3);
                    dnaString[i] = dnaBase[rnd];

                }


                for (int l = 0; l < dnaLength; l++)
                {
                    switch (dnaString[l])
                    {
                        case 'A':
                            dnaStringRight[l] = 'T';
                            break;

                        case 'T':
                            dnaStringRight[l] = 'A';
                            break;

                        case 'C':
                            dnaStringRight[l] = 'G';
                            break;

                        case 'G':
                            dnaStringRight[l] = 'C';
                            break;

                    }
                }
                Console.WriteLine();
                Console.WriteLine(dna);
                for (int i = 0; i < dna.Length; i++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int j = 0; j < dnaLength; j++)
                {
                    Console.Write(dnaString[j] + " ");

                    if (j % 2 == 0)
                    {
                        Console.Write(" - ");
                    }
                    else if (j % 2 != 0)
                    {
                        Console.Write("---");
                    }

                    Console.Write(" " + dnaStringRight[j]);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine(codons);
                for (int i = 0; i < codons.Length; i++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int m = 0; m < dnaString.Length; m++)
                {
                    if (m % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                     Console.Write(dnaString[m]);
                }
                Console.WriteLine();
            }
        }

    }
}
