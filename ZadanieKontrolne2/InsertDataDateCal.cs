using System;

namespace ZadanieKontrolne2
{
    internal class InsertDataDateCal
    {
        public short Year1, Month1, Day1;
        public bool Year2, Month2, Day2;

        public void dateData(out string msg)
        {
            var thisDate = DateTime.Now;

            Console.WriteLine("\nDzisiejsza data: {0}.{1}.{2}",
                thisDate.Day, thisDate.Month, thisDate.Year);

            Console.WriteLine("\nPodaj rok: ");
            var y = Console.ReadLine();
            var canConvertYear = short.TryParse(y, out var year);

            while (!canConvertYear)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę" +
                                  "wprowadzić prawidłowy rok");
                Console.WriteLine("\nPodaj rok: ");
                y = Console.ReadLine();
                canConvertYear = short.TryParse(y, out year);
            }

            Console.WriteLine("Podaj miesiąc (np. 01, 09, 12): ");
            var m = Console.ReadLine();
            var canConvertMonth = short.TryParse(m, out var month);

            while (!canConvertMonth)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę" +
                                  "wprowadzić prawidłowy numer miesiąca");
                Console.WriteLine("\nPodaj numer miesiąca: ");
                m = Console.ReadLine();
                canConvertMonth = short.TryParse(m, out month);
            }

            Console.WriteLine("Podaj dzień (np. 05, 15, 25): ");
            var d = Console.ReadLine();
            var canConvertDay = short.TryParse(d, out var day);

            while (!canConvertDay)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę" +
                                  "wprowadzić prawidłowy numer dnia.");
                Console.WriteLine("\nPodaj numer dnia: ");
                d = Console.ReadLine();
                canConvertDay = short.TryParse(d, out day);
            }

            Year1 = year;
            Month1 = month;
            Day1 = day;

            Year2 = canConvertYear;
            Month2 = canConvertMonth;
            Day2 = canConvertDay;

            msg = null;
        }
    }
}
