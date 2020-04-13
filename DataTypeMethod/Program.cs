using System;

namespace DataTypeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime newjaar;
            newjaar = new DateTime(); // yse the keyword NEW to save class propertis into the variable (as well as with Random)
            newjaar = new DateTime(2020, 1, 1);

            /////////////////////////          Change Format         ////////////////////////////////////////////////

            DateTime geboortedatum = new DateTime(1995, 7, 28, 8, 22, 5);
            string newFormatGeboortedatum = geboortedatum.ToString("yyyy MM dd"); // to change the format of the date visualisation
            //Console.WriteLine(newjaar.Year);
            //Console.WriteLine(newFormatGeboortedatum);

            /////////////////////////          DaysInMonth         ////////////////////////////////////////////////


            var dagen = DateTime.DaysInMonth(geboortedatum.Year, geboortedatum.Month);
            //Console.WriteLine(dagen);

            /////////////////////////          IsLeapYear         ////////////////////////////////////////////////

            bool leapYear = DateTime.IsLeapYear(geboortedatum.Year); // вісокосній год или нет, все , что наинаеться с Is - єто бульен BOOL
                                                                     //Console.WriteLine(leapYear);

            /////////////////////////          Opdracht # 1         ////////////////////////////////////////////////


            DateTime eersteFietsDag = new DateTime(2000, 1, 1, 0, 0, 0);
            string newFormatEersteFietsDag = eersteFietsDag.ToString("dd - yyyy - MM");
            int dagenInMaand = DateTime.DaysInMonth(eersteFietsDag.Year, eersteFietsDag.Month);
            bool isSchrikkelJaar = DateTime.IsLeapYear(eersteFietsDag.Year);

            //Console.WriteLine($"I got my first bike on {eersteFietsDag}");
            //Console.WriteLine($"New format : {newFormatEersteFietsDag}" );
            //Console.WriteLine($"The days in the month is: {dagenInMaand}");
            //Console.WriteLine($"Is it a leak year? {isSchrikkelJaar}");

            /////////////////////////          Min/Max/Noe         ////////////////////////////////////////////////

            DateTime laagsteWaarde = DateTime.MinValue; // it's not a method but a parameter, it's a , so it do not take arguments
            //Console.WriteLine(laagsteWaarde);
            DateTime hoogsteWaarde = DateTime.MaxValue;
            //Console.WriteLine(hoogsteWaarde);
            DateTime currentTijd = DateTime.Now;
            //Console.WriteLine(currentTijd);

            /////////////////////////          AddHours...         ////////////////////////////////////////////////

            DateTime straks = new DateTime(2020, 11, 11, 11, 11, 11);
            straks.AddHours(-1);
            //Console.WriteLine(straks);
            DateTime plus = straks.AddHours(32); // если не сохранить время в отдельную вариабл, время будет отображаться без изменения в аутпуте
            //Console.WriteLine(plus);


            /////////////////////////          Opdracht # 2         ////////////////////////////////////////////////


            DateTime autoBinnenGarage = new DateTime(2020, 1, 29, 12, 30, 0);
            DateTime naTweeDagen = autoBinnenGarage.AddDays(2);
            //Console.WriteLine($"Came to a garage on {autoBinnenGarage}");
            //Console.WriteLine($"Nake a car back: {naTweeDagen}");


            /////////////////////////          TryParse        ////////////////////////////////////////////////

            string getalAlsText = "22";
            int getaal;
            bool kanParsen;
            //getaal = int.Parse(getalAlsText); // gewoon Parsen, but can crash, so we can use .Tryparse (string input, int whereToStoreOutput)
            int.TryParse(getalAlsText, out getaal); // use out keyword to put the output into the variable
                                                    //Console.WriteLine(getaal);

            /////////////////////////          Creating maethods with OUT keyword        ////////////////////////////////////////////////
            // нам нужен аргумент с оут для того, чтобы вернуть больше чем одно значекние, 

            decimal kortingBedragInMain;
            //decimal bedragInclusief = berekenKorting(100, 10, out kortingBedragInMain);

            //Console.WriteLine(bedragInclusief);
            //Console.WriteLine(kortingBedragInMain);

            //}
            //public static decimal berekenKorting(decimal bedragExclusief, float korting, out decimal kortingBedrag)
            //{

            //    decimal bedragInclusief = bedragExclusief * (decimal)(1 - korting/100); // casting to the decimal first
            //    kortingBedrag = bedragInclusief - bedragExclusief;

            //    return bedragInclusief;
            //}

            /////////////////////////          Opdracht # 3         ////////////////////////////////////////////////

            decimal btwBedragInMain;
            decimal btwBedraag1InMain;
            decimal bedragInclusief = berekenInclusiefBTW(100, 15, out btwBedragInMain, out btwBedraag1InMain, 7);


            Console.WriteLine(bedragInclusief);
            Console.WriteLine(btwBedragInMain);
        }

        public static decimal berekenInclusiefBTW(decimal ExclusiefBtw, float btw, out decimal btwBedraag, out decimal btwBedraag1, int num = 0) // int num = 0 in arguments is an argument with default value , 
            //the program will not complain as far as it's already given, so if i give it in the main , it will just assign a new value instead of default
        {
            // нам нужен аргумент с оут для того, чтобы вернуть больше чем одно значекние, 
            decimal inclusiefBTW = ExclusiefBtw * (decimal)(1 + btw / 100); // casting to the decimal first
            btwBedraag = inclusiefBTW - ExclusiefBtw;
            btwBedraag1 = inclusiefBTW + ExclusiefBtw; // нам нужен аргумент с out для того, чтобы вернуть больше чем одно значекние,  можно добавлять стольок, сколь хочешь, главное  в мейн сохранять аутпут в вариабл
            // каждый out аргумент нужно написать в теле тметода, для того, чтобы его получить назад

            return inclusiefBTW;
        }
    }
}
