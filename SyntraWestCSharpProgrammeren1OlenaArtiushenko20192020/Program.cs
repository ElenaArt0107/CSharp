using System;
using System.Collections.Generic;

namespace SyntraWestCSharpProgrammeren1OlenaArtiushenko20192020
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<decimal> transacties = new Queue<decimal>();
            List<decimal> negatief = new List<decimal>();
            List<decimal> positief = new List<decimal>();
            decimal somPositief = 0, someNgatief = 0;
            int aantalP = 0, aantalN =0;

            transacties.Enqueue(200);
            transacties.Enqueue(-24);
            transacties.Enqueue(56);
            transacties.Enqueue(455);
            transacties.Enqueue(102);
            transacties.Enqueue(-45);
            transacties.Enqueue(-4);
            transacties.Enqueue(123);

            while (transacties.Count > 0)
            {
                decimal num = transacties.Dequeue();
                if (num>=0)
                {
                    positief.Add(num);
                    somPositief += num;
                    aantalP++;
                }
                else
                {
                    negatief.Add(num);
                    someNgatief += num;
                    aantalN++;
                }
            }
            Console.WriteLine($"NEGATIEF: Som = {someNgatief}, aantal {aantalN}\nPOSITIEF: Som = {somPositief}, aantal {aantalP} ");
        }
    }
}
