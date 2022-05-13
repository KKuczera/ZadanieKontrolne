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
                        FigureData.insertLengthH();*/

                        InsertData.insertNumber("Wprowadź długość boku a:");
                        lengthA = InsertData.number;
                        InsertData.insertNumber("Wprowadź długość wysokości (h):");
                        lengthH = InsertData.number;
                        break;
                    case 4:
                        //FigureData.insertLengthR();

                        InsertData.insertNumber("Wprowadź długość promienia (r):");
                        lengthR = InsertData.number;
                        break;
                    default:
                        Console.WriteLine("Podaj poprawną cyfrę/liczbę.");
                        break;
                }
            }
        }
    }
}
