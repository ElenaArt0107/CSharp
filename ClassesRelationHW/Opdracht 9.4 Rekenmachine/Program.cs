using System;

namespace Opdracht_9._4_Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1 = 0;
            double getal2 = 0;
            double power = 0;
            string operatie = string.Empty, operatieType = string.Empty;
            double resultaat = 0;
            int keuze = 0;

            Rekenmachine myCalculator = new Rekenmachine();

            myCalculator.ToonMenu();

            keuze = GetGetalenBetweenTwoValues(0, 5);

            while (keuze != 0)
            {
                switch(keuze)
                {
                    case 1:
                        operatie = "+";
                        operatieType = "Optelen";
                        Console.WriteLine(operatieType);
                        for (int i = 0; i < operatieType.Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 1 in:");
                        getal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 2 in:");
                        getal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        resultaat = myCalculator.Add(getal1, getal2);
                        Console.WriteLine();
                        break;
                    case 2:
                        operatie = "-";
                        operatieType = "Verschil";
                        Console.WriteLine(operatieType);
                        for (int i = 0; i < operatieType.Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 1 in:");
                        getal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 2 in:");
                        getal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        resultaat = myCalculator.Subtract(getal1, getal2);
                        Console.WriteLine();
                        break;
                    case 3:
                        operatie = "*";
                        operatieType = "Product";
                        Console.WriteLine(operatieType);
                        for (int i = 0; i < operatieType.Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 1 in:");
                        getal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 2 in:");
                        getal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        try
                        {
                            resultaat = myCalculator.Multiply(getal1, getal2);
                        }
                        catch
                        {

                            resultaat = double.NaN;
                        }
                       
                        Console.WriteLine();
                        break;
                    case 4:
                        operatie = "/";
                        operatieType = "Quatient";
                        Console.WriteLine(operatieType);
                        for (int i = 0; i < operatieType.Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 1 in:");
                        getal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 2 in:");
                        getal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        resultaat = myCalculator.Divide(getal1, getal2);
                        Console.WriteLine();
                        break;
                    case 5:
                        operatie = "^";
                        operatieType = "Match";
                        Console.WriteLine(operatieType);
                        for (int i = 0; i < operatieType.Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 1 in:");
                        getal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Geef getal 2 in:");
                        getal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        resultaat = myCalculator.Power(getal1, getal2);
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine($"{getal1} {operatie} {getal2} is {resultaat}");
                Console.WriteLine("Druk op Enter om verder te gaan");
                Console.ReadLine();

                Console.Clear();
                myCalculator.ToonMenu();
                keuze = GetGetalenBetweenTwoValues(0, 5);
            }

            

        }
        public static int GetGetalenBetweenTwoValues(int get1, int get2)
        {
            Random rnd = new Random();
            int random = rnd.Next(get1, get2);
            return random;
        }

        public static int GetGetaal()
        {
            Random rnd = new Random();
            int random = rnd.Next();
            return random;
        }
    }
}
