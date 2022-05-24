using System;

namespace ZadanieKontrolne
{
    internal class InsertDataFigurePerimeterCal
    {
        public static short WhichFigure;

        public static float lengthA, lengthB, lengthC, lengthR;

        public static void figurePerimeterData()
        {
            Console.WriteLine("\nWybierz figurę, której pole chcesz obliczyć: " +
                "\n\t1. Kwadrat\n\t2. Prostokąt\n\t3. Trójkąt\n\t4. Koło");
            var whFigure = Console.ReadLine();
            var canConvertWhichFigure = short.TryParse(whFigure, out var whichFigure);

            while (!canConvertWhichFigure)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę" +
                                  "wprowadzić prawidłową długość boku a");
                whFigure = Console.ReadLine();
                canConvertWhichFigure = short.TryParse(whFigure, out whichFigure);
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
                        lengthB = InsertData.insertNumber("Wprowadź długość boku b:");
                        lengthC = InsertData.insertNumber("Wprowadź długość boku c:");
                        break;
                    case 4:
                        lengthR = InsertData.insertNumber("Wprowadź długość promienia (r):");
                        break;
                    default:
                        Console.WriteLine("Podano niepoprawną wartość.");
                        break;
                }
            }
        }
    }
}
