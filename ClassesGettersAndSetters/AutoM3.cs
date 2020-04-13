using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesGettersAndSetters
{
    class AutoM3


    {
        private int _huidigeVersnelling = 0;

        public string Merk { get; set; }
        public ConsoleColor Kleur { get; set; }
        public int MaxVersnelling { get; set; }
        public int HuidigeVersnelling
        {
            get { return _huidigeVersnelling; }
            set
            {
                int mogelijkeHuidigeVersnelling = value;
                if (mogelijkeHuidigeVersnelling >= 0 && mogelijkeHuidigeVersnelling <= MaxVersnelling)
                {
                    _huidigeVersnelling = value;
                }
                else
                {
                    Console.WriteLine("De huidige versnelling moet kleiner of gelijk aan 0 zijn en " +
                    "Groter of gelijk aan de maxVersnelling");
                    return;
                }

                public void Info()
                {
                    Console.WriteLine("Auto: ");
                    Console.WriteLine("----------");
                    Console.WriteLine();
                    Console.WriteLine($"Merk: {Merk}");
                    Console.WriteLine($"Kleur: {Kleur.ToString()}"); //they are enumeration. so not to show the values but string itself
                    Console.WriteLine($"Max Versnelling: {MaxVersnelling}");

                    Console.WriteLine($"Huidige Versnelling: {HuidigeVersnelling}");
                    Console.WriteLine();

                }
            }
        }
    }
}
