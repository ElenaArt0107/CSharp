using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesGettersAndSetters
{
    class AutoM2
    {

        public AutoM2(string merk, ConsoleColor kleur, double maxVersnelling, double huidigeVersnelling = 0)
        {
            //this._merk = merk;
            //this._kleur = kleur;
            //this._maxVersnelling = maxVersnelling;

            // we can use here the featuresd as well as private variable
            Merk = merk;
            Kleur = kleur;
            MaxVersnelling = maxVersnelling;
        }

        private string _merk;

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        private ConsoleColor _kleur;

        public ConsoleColor Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }
        private double _maxVersnelling;

        public double MaxVersnelling
        {
            get { return _maxVersnelling; }
            private set { _maxVersnelling = value; }
        }

        private double _huidigeVersnelling;

        public double HuidigeVersnelling
        {
            get { return _huidigeVersnelling; }
            set {
                if (value < 0 || value > _maxVersnelling)
                {
                    Console.WriteLine("De huidige versnelling moet kleiner of gelijk aan 0 zijn en " +
                    "Groter of gelijk aan de maxVersnelling");
                    return;
                }
                _huidigeVersnelling = value;
            }
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
