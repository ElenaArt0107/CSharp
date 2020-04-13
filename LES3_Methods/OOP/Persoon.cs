using System;
using System.Collections.Generic;
using System.Text;


namespace Personen
{
    /*
    * public - Доступ не ограничен.
    * private - Доступ возможен только из этого класса.

    * 
    * public void Schreeuw() has no input parameters because we ask for a person to give the values that are already prescribed to him
    */


    public class Persoon
    {
        public string voornaam;
        public string familienaam;
        public DateTime gebortedatum;
        //private string echteNaam;

        public string echteNaam;


        public void Schreeuw()
        {
            Console.WriteLine($"I'm {voornaam} {familienaam}.\nI've been born on {gebortedatum.ToString("dd.MMyyyy")}");

        }
        /// /////////////////////////////////////////////// CREATING A CONSTRUCTOR ////////////////////////////////////////////////////
        /*
         * конструктор должен днаходиться внутри класса, а параметрі указанны как параметры к методу
         * отличие от метода
         * 1. не имеет конкретного типа
         * 2. все параметры должны быть прописаны внутри тела и быть аргументами для основных характеристик (переменных) класса - соответствоввать им
         */

        public Persoon()
        {
            Console.WriteLine("Hij leeft !");
        }
        public Persoon(string voornaamInput, string familienaamInput, DateTime gebortedatumInput)
        {
            voornaam = voornaamInput;
            familienaam = familienaamInput;
            gebortedatum = gebortedatumInput;
        }
      /////////////////////////////////////// imbedded constructor into constructor :THIS(param1, param2...) //////////////////////////////
      /*
       * can be imbedded in the other constructor e.g. when we have the same parameters
      */
        public Persoon(string voornaamInput, string familienaamInput, DateTime gebortedatumInput, string echteNaamInput)
             : this(voornaamInput, familienaamInput, gebortedatumInput)
        {
            
            //voornaam = voornaamInput;
            //familienaam = familienaamInput;
            //gebortedatum = gebortedatumInput; // was already in constructor? so we can use it inside:


            echteNaam = echteNaamInput;
        }

    }
    
    
}
