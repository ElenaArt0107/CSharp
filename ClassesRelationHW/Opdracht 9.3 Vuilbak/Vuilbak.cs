using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_9._3_Vuilbak
{
    class Vuilbak
    {
        List<string> inhoudVuilbak;
        int grotteVuilbak;

        public Vuilbak(int grotteVuilbak)
        {
            this.grotteVuilbak = grotteVuilbak;
            inhoudVuilbak = new List<string>(grotteVuilbak);
            Console.WriteLine($"Vuilbak met plaats voor {grotteVuilbak} stuken is aangemaakt");
        }

        public void WerpVuilnis(string vuil)
        {

            //string vuil = Console.ReadLine();

            if (inhoudVuilbak.Count < grotteVuilbak)
            {
                Console.WriteLine($"{vuil} is weg gesmeten");
                inhoudVuilbak.Add(vuil);

            }
            else
            {

                Console.WriteLine("de vuilnisbak zit vol. Leeg deze eerst");
                
            }
            
           
        }

        public void LeegVuilnis()
        {
            Console.WriteLine($"{inhoudVuilbak.Count} stukken vuilnis werd geleegd");
    
            inhoudVuilbak.Clear();
        }

    }
}
