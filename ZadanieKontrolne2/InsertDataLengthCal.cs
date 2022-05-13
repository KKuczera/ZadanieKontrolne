using System;

namespace ZadanieKontrolne2
{
    internal class InsertDataLengthCal
    {
        public static short Length;
        public static void lengthData()
        {
            Console.WriteLine("\nPodaj napis: ");
            var writing = Console.ReadLine();
            var length = Calculators.length(writing);

            Length = length;
        }
    }
}
