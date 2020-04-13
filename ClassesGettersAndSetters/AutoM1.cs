using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesGettersAndSetters
{
    public class AutoM1
    {
        private string merk;
        private ConsoleColor kleur;
        private double maxVersnelling;
        private double huidigeVersnelling;

        public AutoM1(string merk, ConsoleColor kleur, double maxVersnelling, double huidigeVersnelling = 0)
        {
            this.merk = merk;
            this.kleur = kleur;
            this.maxVersnelling = maxVersnelling;

        }

        
        public string GetMerk()
        {
            return merk;
        }
        public ConsoleColor GetKluer()
        {
            return kleur;
        }

        public double GetMaxVersnellingr()
        {
            return maxVersnelling;
        }

        public double GetHuidigeVersnelling()
        {
            return huidigeVersnelling;
        }

        public void SetMerk(string merk)
        {
            this.merk = merk;
        }

        public void SetKleur(ConsoleColor kleur)
        {
            this.kleur = kleur;
        }
        public void SetMaxVersnelling(double maxVersnelling)
        {
            this.maxVersnelling = maxVersnelling;
        }

        public void SetHuidigeVersnelling(double huidigeVersnelling)
        {
            if (huidigeVersnelling < 0 || huidigeVersnelling > maxVersnelling)
            {
                Console.WriteLine("De huidige versnelling moet kleiner of gelijk aan 0 zijn en " +
                    "Groter of gelijk aan de maxVersnelling");
                return;
            }
            this.huidigeVersnelling = huidigeVersnelling;

        }

        public void Info()
        {
            Console.WriteLine("Auto: ");
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine($"Merk: {GetMerk()}");
            Console.WriteLine($"Kleur: {GetKluer().ToString()}"); //they are enumeration. so not to show the values but string itself
            Console.WriteLine($"Max Versnelling: {GetMaxVersnellingr()}");

            Console.WriteLine($"Huidige Versnelling: {GetHuidigeVersnelling()}");
            Console.WriteLine();

        }
    }
}
