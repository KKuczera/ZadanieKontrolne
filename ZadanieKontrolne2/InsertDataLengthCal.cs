using System;

namespace ZadanieKontrolne
{
    internal class InsertDataLengthCal
    {
        public static short Length;
        public static short lengthData()
        {
            Console.WriteLine("\nPodaj napis: ");
            var writing = Console.ReadLine();
            var length = Calculators.length(writing);

            Length = length;

            return Length;
        }
    }
}
