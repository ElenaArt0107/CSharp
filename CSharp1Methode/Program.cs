using System;

namespace CSharp1Methode
{
    class Program
    {
        static void Main(string[] args)                     // does  some actions
        {
            float resultaat = Som(2, 4);    
            Console.WriteLine(resultaat);
        }

        static float Som (float num1, float num2)           // returns a value
        {
            return num1 + num2;         
        }

        // shortening

        static float Som1(float num1, float num2) => num1 + num2;

        static void Som2(float num1, float num2)=> Console.WriteLine(num1 + num2);
    }
}
