using System;
using System.Collections.Generic;

namespace RestaurantExer
{
  
    class Program
    {
        static void Main(string[] args)
        {
            List<Besteling> behandeldeBestelingen = new List<Besteling>();
            Queue<Besteling> bestelingen = new Queue<Besteling>();

            Besteling b1 = new Besteling(1, MenuItem.Nagerecht);
            Besteling b2 = new Besteling(2, MenuItem.MENU);
            Besteling b3 = new Besteling(3, MenuItem.Hoofdgerecht);

            bestelingen.Enqueue(b1);
            bestelingen.Enqueue(b2);
            bestelingen.Enqueue(b3);

            while(bestelingen.Count> 0)
            {
                Besteling bTemp =  bestelingen.Dequeue();
                bTemp.VolgendeStap();
                if (bTemp.status == OrderStatus.Behandeld)
                {
                    behandeldeBestelingen.Add(bTemp);
                }
                else
                {
                    bestelingen.Enqueue(bTemp); // again into a queue
                }
                Console.WriteLine($"Tnr: {bTemp.tafelNr}, " +
                    $"Menu item: {bTemp.menuItem}, " +
                    $"Status {bTemp.status}.");
            }


        }
    }
}
