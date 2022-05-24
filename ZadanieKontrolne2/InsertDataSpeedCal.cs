using System;

namespace ZadanieKontrolne
{
    internal class InsertDataSpeedCal
    {
        public static short whichUnits;

        public static float metresToKilometres, kilometresToMetres;
        public static void speedData()
        {
            Console.WriteLine("\nWybierz, z jakich jednostek na jakie" +
                              " chcesz obliczyć prędkość: \n\t1. km/h na m/s" +
                              "\n\t2. m/s na km/h");
            var which = Console.ReadLine();
            var canConvertWhichUnits = short.TryParse(which, out var units);

            while (!canConvertWhichUnits)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową cyfrę.");
                Console.WriteLine("\nWybierz kalkulator: ");
                which = Console.ReadLine();
                canConvertWhichUnits = short.TryParse(which, out units);
            }

            if (canConvertWhichUnits)
            {
                whichUnits = units;
            }

            switch (whichUnits)
            {
                case 1:
                    kilometresToMetres = InsertData.insertNumber("\nPodaj prędkość: ");
                    break;
                case 2:
                    metresToKilometres = InsertData.insertNumber("\nPodaj prędkość: ");
                    break;
            }
        }
    }
}
