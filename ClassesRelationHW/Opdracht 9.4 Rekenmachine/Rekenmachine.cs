using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_9._4_Rekenmachine
{
    class Rekenmachine
    {
       public double getal1;
        public double getal2;
        public double power;
        public double resultaat = 0;

        //public Rekenmachine(double getal1, double getal2, double power)
        //{
        //    this.getal1 = getal1;
        //    this.getal2 = getal2;
        //    this.power = power;
        //}
        public double Add(double getal1, double getal2)
        {
            resultaat = getal1 + getal2;
            return resultaat;
        }
        public double Subtract(double getal1, double getal2)
        {
            resultaat = getal1 - getal2;
            return resultaat;
        }

        public double Multiply(double getal1, double getal2)
        {
            resultaat = getal1 * getal2;
            return resultaat;
        }

        public double Divide(double getal1, double getal2)
        {
            //while (getal2==0)
            //{
            //    Console.WriteLine("Je kan niet op 0 delen");
            //    Console.WriteLine( "Geef de correkt getal in:");
            //    getal2 = double.Parse(Console.ReadLine());
            //    return getal2;
            //}
            
                resultaat = getal1 / getal2;
            
                return resultaat;
           
            
        }
        public double Power(double getal1, double getal2)
        {
            resultaat = Math.Pow(getal1, getal2);
            return resultaat;
        }

        public void ToonMenu()
        {
            Console.WriteLine("Welke berekening wil je maken?\n");
            Console.WriteLine("1. Som");
            Console.WriteLine( "2. Verschil");
            Console.WriteLine("3. Product");
            Console.WriteLine("4. Quotient");
            Console.WriteLine("5. Match");
            Console.WriteLine();

            Console.WriteLine("0. Stop");
        }
       
    }
}
