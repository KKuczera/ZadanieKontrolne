using System;

namespace ZadanieKontrolne2
{
    internal class InsertDataBMICal
    {
        public static float userHeight, userWeight;
        public static bool CanConvertHeight, canConvertWeight;
        //Insert data for calculate BMI
        public static void bmiData()
        {
            Console.WriteLine("\nWprowadź wzrost (w metrach): ");
            var height = Console.ReadLine();
            var canConvertH = float.TryParse(height, out var h);

            while (!canConvertH)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową wysokość");
                Console.WriteLine("\nPodaj wzrost (w metrach): ");
                height = Console.ReadLine();
                canConvertH = float.TryParse(height, out h);
            }

            Console.WriteLine("Wprowadź masę ciała (w kg): ");
            var weight = Console.ReadLine();
            var canConvertW = float.TryParse(weight, out var w);

            while (!canConvertW)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową masę ciała");
                Console.WriteLine("\nWprowadź masę ciała (w kg): ");
                weight = Console.ReadLine();
                canConvertW = float.TryParse(weight, out w);
            }
        }
    }
}
