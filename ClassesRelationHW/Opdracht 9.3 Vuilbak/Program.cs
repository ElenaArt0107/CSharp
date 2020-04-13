using System;

namespace Opdracht_9._3_Vuilbak
{
    class Program
    {
        static void Main(string[] args)
        {
            int grooteVuil = 3;
            Vuilbak vuilbak = new Vuilbak(grooteVuil);

            Console.WriteLine("Wat is de vuilstuck dat je wilt weg smeten?");
            vuilbak.WerpVuilnis(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Wat is de vuilstuck dat je wilt weg smeten?");
            vuilbak.WerpVuilnis(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Wat is de vuilstuck dat je wilt weg smeten?");
            vuilbak.WerpVuilnis(Console.ReadLine());
            Console.WriteLine();


            vuilbak.LeegVuilnis();
            Console.WriteLine();
            
            Console.WriteLine("Wat is de vuilstuck dat je wilt weg smeten?");
            vuilbak.WerpVuilnis(Console.ReadLine());
            Console.WriteLine();

            vuilbak.LeegVuilnis();
            Console.WriteLine();
        }
    }
}
