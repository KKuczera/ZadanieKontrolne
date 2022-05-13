using System;

namespace ZadanieKontrolne2
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
                    InsertData.insertNumber("\nPodaj prędkość: ");
                    kilometresToMetres = InsertData.number;

                    /*Console.WriteLine("\nPodaj prędkość w km/h:");
                    var speed_kilometresmetres = Console.ReadLine();
                    var canConvertSpeedKM = float.TryParse(speed_kilometresmetres, out var speedInKilometres);

                    while (!canConvertSpeedKM || speedInKilometres <= 0)
                    {
                        Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                          "wprowadzić prawidłową prędkość.");
                        Console.WriteLine("\nPodaj prędkość: ");
                        speed_kilometresmetres = Console.ReadLine();
                        canConvertSpeedKM = float.TryParse(speed_kilometresmetres, out speedInKilometres);
                    }

                    if (canConvertSpeedKM)
                    {
                        kilometresToMetres = speedInKilometres;
                    }*/
                    break;
                case 2:
                    InsertData.insertNumber("\nPodaj prędkość: ");
                    metresToKilometres = InsertData.number;

                    /*Console.WriteLine("\nPodaj prędkość w m/s:");
                    var speed_metres = Console.ReadLine();
                    var canConvertSpeedM = float.TryParse(speed_metres, out var speedInMetres);

                    while (!canConvertSpeedM || speedInMetres <= 0)
                    {
                        Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                          "wprowadzić prawidłową prędkość.");
                        Console.WriteLine("\nPodaj prędkość: ");
                        speed_metres = Console.ReadLine();
                        canConvertSpeedM = float.TryParse(speed_metres, out speedInMetres);
                    }

                    if (canConvertSpeedM)
                    {
                        metresToKilometres = speedInMetres;
                    }*/
                    break;
            }
        }
    }
}
