using System;

namespace Opdracht_9._2_Dagboek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dagboek myDiary = new Dagboek();

            myDiary.SchrijfNieuwePagina();
            myDiary.SchrijfNieuwePagina();
            myDiary.SchrijfNieuwePagina();
            myDiary.SchrijfNieuwePagina();


            myDiary.PrintBoek();
        }
    }
}
