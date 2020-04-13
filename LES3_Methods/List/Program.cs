using System;
//using Personen;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////// List<T> ////////////////
            /// u have to import class: using System.Collections.Generic;
            /// 

            List<int> getalen = new List<int>();
            List<int> getalen1 = new List<int>();

            List<string> text = new List<string>();
            List<DateTime> today = new List<DateTime>();
            //List<Persoon> people = new List<Persoon>();

            getalen.Add(5);
            getalen.Add(66);
            getalen.Add(42);

            getalen1.Add(105);
            getalen1.Add(166);
            getalen1.Add(142);

            //to print out the list 'for-loop' or 'foreach'

            Console.WriteLine("Before");

            PrintList(getalen);

            getalen.Sort(); // first sort, then reverse
            getalen.Reverse();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("After sorting and reversing:");

            PrintListForEach(getalen); // without 'static' in name of func we get 'is required for non-static method...'

            getalen.AddRange(getalen1);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("After adding a range from other list:");
            PrintListForEach(getalen);

            Console.WriteLine();


        }
        public static void PrintList(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                int getaal = l[i];
                Console.Write(getaal + " ");
            }
            return;
        }

        public static void PrintListForEach(List<int> l)
        {
            foreach (int getaal in l)
            {
                Console.Write(getaal + " ");
            }
            return;
        }
    }
}
