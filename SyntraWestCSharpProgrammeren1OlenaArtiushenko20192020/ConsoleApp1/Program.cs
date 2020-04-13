using System;
using System.Collections.Generic;
using TransactiesMetClass;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> transactiesD = new Dictionary<string, decimal>();

            Queue<Transactie> transactiesQ = new Queue<Transactie>();

            Transactie louis = new Transactie("Louis", 200);
            Transactie karen = new Transactie("Karen", 150);
            Transactie sarah = new Transactie("Sarah", -100);
            Transactie karen1 = new Transactie("Karen", -50);
            Transactie louis1 = new Transactie("Louis", 20);
            Transactie emma = new Transactie("Emma", 4);
            Transactie louis2 = new Transactie("Louis", -200);

            transactiesQ.Enqueue(louis);
            transactiesQ.Enqueue(karen);
            transactiesQ.Enqueue(sarah);
            transactiesQ.Enqueue(karen1);
            transactiesQ.Enqueue(louis1);
            transactiesQ.Enqueue(emma);
            transactiesQ.Enqueue(louis2);

            while (transactiesQ.Count > 0)
            {
                Transactie personTemp = transactiesQ.Dequeue();
                if (transactiesD.ContainsKey(personTemp.naam))
                {
                    transactiesD[personTemp.naam] += personTemp.bedrag;
                }
                else
                {
                    transactiesD.Add(personTemp.naam, personTemp.bedrag);
                }
            }
            PrintOutDict(transactiesD);
        }
        public static void PrintOutDict<Tkey, Tvalue>(Dictionary <Tkey, Tvalue> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key} heeft {item.Value} euro");
            }
        }
    }
}
