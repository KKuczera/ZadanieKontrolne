using System;

namespace ZadanieKontrolne2
{
    internal class InsertDataFigurePerimeterCal
    {
        public static short WhichFigure;

        public static float lengthA, lengthB, lengthC, lengthH, lengthR;

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
                        //FigureData.insertLengthA();

                        InsertData.insertNumber("Wprowadź długość boku a:");
                        lengthA = InsertData.number;
                        break;
                    case 2:
                        /*FigureData.insertLengthA();
                        FigureData.insertLengthB();*/

                        InsertData.insertNumber("Wprowadź długość boku a:");
                        lengthA = InsertData.number;
                        InsertData.insertNumber("Wprowadź długość boku b:");
                        lengthB = InsertData.number;
                        break;
                    case 3:
                        /*FigureData.insertLengthA();
                        FigureData.insertLengthB();
                        FigureData.insertLengthC();*/

                        InsertData.insertNumber("Wprowadź długość boku a:");
                        lengthA = InsertData.number;
                        InsertData.insertNumber("Wprowadź długość boku b:");
                        lengthB = InsertData.number;
                        InsertData.insertNumber("Wprowadź długość boku c:");
                        lengthC = InsertData.number;
                        break;
                    case 4:
                        //FigureData.insertLengthR();

                        InsertData.insertNumber("Wprowadź długość promienia (r):");
                        lengthR = InsertData.number;
                        break;
                    default:
                        Console.WriteLine("Podano niepoprawną wartość.");
                        break;
                }
            }
        }
    }
}
