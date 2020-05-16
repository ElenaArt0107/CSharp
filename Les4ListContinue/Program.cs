using System;
using System.Collections.Generic;
using Les4ListContinue;

//using Wernemers;

namespace Les4ListContinue
{
    enum Functie // enumeration is a  refernce type (could be used as a type the same way as the primitive ones : int , string...)
    {
        Boekhouder,
        Lasser,
        CEO,
        CFO

    }
    enum SchakstukWaarde // enumeration
    {
        Pion, // get the value one by one although u want to chage it
        Paard ,
        Loper,
        Toren = 8, // get the value one by one although u want to chage it the next go into the raw after
        Koningin

    }
    class Wernemer // a refernce type (could be used as a type the same way as the primitive ones : int , string...)
    {
        public string naam;
        public string fnaam;

        public Wernemer(string naam, string fnaam)
        {
            this.naam = naam;
            this.fnaam = fnaam;
        }
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {

            /*

            var werknamers = new List<Wernemer>();
            var p1 = new Wernemer("I", "L");
            var p2 = new Wernemer("S", "R");
            var p3 = new Wernemer("K", "T");
            werknamers.Add(p1);
            werknamers.Add(p2);
            werknamers.Add(p3);
            
            foreach (var item in werknamers)
            {
                var functie = werknamers.Functie;
                switch (functie)
                {
                    case Functie.Boekhouder:
                        Console.WriteLine($"{} ? 1567");
                        break;

                    case Functie.CEO:
                        Console.WriteLine($"{} ? 6543");
                        break;
                }
            }

            */
            //////////////////////////////////////////////////////         Collections                  ////////////////////////////////////////////
            //////////////////////////////// GET THE VALUE FROM ENUM ELEMENT: like a tuple in Python //////////////////////////////////////////////////////
            ///using System.Collections.Generic;
            ///By default, the first item of an enum has the value 0. The second has the value 1, and so on.

            // To get the integer value from an item, you must explicitly convert the item to an int:
            Console.WriteLine("GET THE VALUE FROM ENUM");
            int paardValue = (int) SchakstukWaarde.Paard;
            Console.WriteLine($"Paard waarde : {paardValue}");
            Console.WriteLine();

            /////////////////////////////////////////// print out enumeration ///////////////////////////////////////////
            Console.WriteLine("ENUM CLASS");
            Console.WriteLine();
            // Enum is a claass, that has its own methods e.g. GetValues:

            Type funktieType = typeof(Functie); // convertion itself
            //Enum.GetValues(funktieType); // not to have an exception we nshould convert from a class to the type first:
             

            foreach (var item in Enum.GetValues(funktieType)) // it becomes a listm so we can pring it out zith a 'foreach'
            {
                Console.WriteLine(item);
            }
            //returns an arrays of strings

            /////////////////////////////// Exercise 1 met enu //////////////////////////////

            Console.WriteLine("Exercise 1 met enu");
            Bij bij = new Bij(BijJob.StingPatrol);
            bij.Toon();


            ////////////////////////////// FIFO ///// first in first out/////////////in comparison zith list<T> = LIFO = last in first out////////////////////////////////////////
            ///////////////////////////// QUEUE<T> //////////////////////////////////////////
            /// using System.Collections.Generic; to all collections namespace
            //
            Console.WriteLine();
            Console.WriteLine("QUEUE Mthods");
            Queue<int> transacties;
            transacties = new Queue<int>();
            // to add the element use method Enqueue:

            transacties.Enqueue(3000);
            transacties.Enqueue(-300);
            transacties.Enqueue(50);
            transacties.Enqueue(-100);
            transacties.Enqueue(50);
            transacties.Enqueue(-150);


            // .Count = gives the quantity of elems in a queue;

            //Dequeue(); returns  an int  and 'delete' the very first value in a queue while the second become first: 

            int t = transacties.Dequeue();
            Console.WriteLine(t);
            Console.WriteLine($"Count: {transacties.Count}");

            //Peek() returns the very first value but does not delete it:

            int v = transacties.Peek();
            Console.WriteLine(v);
            Console.WriteLine($"Count: {transacties.Count}");
            Console.WriteLine();

            // foreach for arrays and Collections:
            Console.WriteLine("printing out the Queue");
            foreach (var item in transacties)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("Queue with while and sum");

            int total = 0;
            while (transacties.Count > 0)
            {
                int lt = transacties.Dequeue();

                total += lt;
            }
            Console.WriteLine($"Totaal: {total}");
            Console.WriteLine($"Count: {transacties.Count}");
        }
    }
}
