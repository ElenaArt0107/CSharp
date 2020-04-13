using System;

namespace PersoonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p = new Persoon("El", "Art");
            Console.WriteLine(p.ToString());

            Type t = p.GetType();

            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);

        }
    }
}
