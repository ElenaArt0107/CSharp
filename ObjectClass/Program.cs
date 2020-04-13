using System;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // with f12 you can go to the constructor of type object 
            // any objact has thes methods and features
            Object o = new Object();
            

            String text = new String("Bloemen"); // if we want to make a refernce on it
            string text2 = "Algebra";

            object o2 = new object();
            string text3 = o2.ToString();
            Console.WriteLine(text3);
            Console.WriteLine("-----------------");


            Type t = o2.GetType();
            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Namespace);

            Console.WriteLine("-----------------");





        }
    }
}
