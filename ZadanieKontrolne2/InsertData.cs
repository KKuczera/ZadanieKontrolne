using System;

namespace ZadanieKontrolne
{
    internal class InsertData
    {
        public static float number;

        public static bool canConvertNumber;

        public static float insertNumber(string komunikat)
        {
            Console.WriteLine(komunikat);
            var num1 = Console.ReadLine();
            var canConvertNumber1 = float.TryParse(num1, out var number1);

            while (!canConvertNumber1)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową cyfrę/liczbę");
                Console.WriteLine("\nPodaj cyfrę/liczbę: ");
                num1 = Console.ReadLine();
                canConvertNumber1 = float.TryParse(num1, out number1);
            }

            if (canConvertNumber1)
            {
                number = number1;
                canConvertNumber = canConvertNumber1;
            }

            return number;
        }
    }
}
