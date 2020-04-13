using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle(10);
            Console.WriteLine();
        }
        static void DrawTriangle( int katet)
        {
            char spase = ' ';
            char star = '*';


            for (int i = katet, n = 0; i > 0; i--, n++)
            {
                int j = 0;
                for (; j < i; j++)
                {
                    Console.Write(spase);
                }
                Console.Write(star);

                if (i < katet)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (l == 0)
                        {
                            Console.Write(spase);
                        }
                        else
                        {
                            for (int m = 0; m < 2; m++)
                            {
                                Console.Write(spase);
                            }
                        }
                    }
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < katet+1; i++)
            {
                Console.Write(star + " ");
            }
            Console.WriteLine();
            return;
        }
    }
}
