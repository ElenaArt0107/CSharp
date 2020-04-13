using System;
using Personen; // надо использовать тоже самое пространство имен, что и клас, который мы создали
using Tuinen;

namespace Class
{
    /*
     * классы 
     * создаем в отдельном файле решения- добавить- класс- имя= имя класа
     * ХАК: лучше сохранять один класс в одном файле
     * вызвать обьект с большой буквы и ключевым словом :новый обьект:
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Persoon pol = new Persoon();
            pol.voornaam = "Pol";
            pol.familienaam = "Polsen";
            pol.gebortedatum = DateTime.Now;

            pol.Schreeuw();
            Console.WriteLine();

            Persoon linde = new Persoon();
            linde.voornaam = "Linde";
            linde.familienaam = "Boon";
            linde.gebortedatum = DateTime.Now;

            linde.Schreeuw();
            Console.WriteLine();
            */

            /* 
             * exercise:
            Tuin garden = new Tuin();
            garden.locality = "Brugge";
            garden.squareMeters = 15f;
            garden.registerNumber = 5190;

            garden.Descript();
            */

            //Persoon pol = new Persoon("Pol", "Polsen", DateTime.Now);
            //pol.Schreeuw();

            Tuin garden = new Tuin("Brugge", 1234, 5.7f);
            garden.Descript();

            Console.WriteLine();

            Tuin garden1 = new Tuin("Knokke", 5555, 6.7f, DateTime.Now);
            garden1.Descript();
        }

    }
}
