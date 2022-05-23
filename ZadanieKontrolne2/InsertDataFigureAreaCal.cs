using System;

namespace ZadanieKontrolne2
{
    internal class InsertDataFigureAreaCal
    {
        public static short WhichFigure;

        public static float lengthA, lengthB, lengthH, lengthR;

        public static void figureAreaData()
        {
            Console.WriteLine("\nWybierz figurę, której pole chcesz obliczyć: " +
                "\n\t1. Kwadrat\n\t2. Prostokąt\n\t3. Trójkąt\n\t4. Koło");
            var which_figure = Console.ReadLine();
            var canConvertWhichFigure = short.TryParse(which_figure, out var whichFigure);

            while (!canConvertWhichFigure)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj numer figury: ");
                which_figure = Console.ReadLine();
                canConvertWhichFigure = short.TryParse(which_figure, out whichFigure);
            }

            if (canConvertWhichFigure)
            {
                WhichFigure = whichFigure;

                switch (WhichFigure)
                {
                    case 1:
                        lengthA = InsertData.insertNumber("Wprowadź długość boku a:");
                        break;
                    case 2:
                        lengthA = InsertData.insertNumber("Wprowadź długość boku a:");
                        lengthB = InsertData.insertNumber("Wprowadź długość boku b:");
                        break;
                    case 3:
                        lengthA = InsertData.insertNumber("Wprowadź długość boku a:");
                        lengthH = InsertData.insertNumber("Wprowadź długość wysokości (h):");
                        break;
                    case 4:
                        lengthR = InsertData.insertNumber("Wprowadź długość promienia (r):");
                        break;
                    default:
                        Console.WriteLine("Podaj poprawną cyfrę/liczbę.");
                        break;
                }
            }
        }
    }
}
