using System;

namespace _8._16_Print_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getalen = { 2, 8, 7, 15, 16 };
            Console.WriteLine("Printing Array");
            PrintArray(getalen);

        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("        " + array[i]);
            }
        }
    }
}
