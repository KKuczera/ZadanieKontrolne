 using System;

namespace ZadanieKontrolne
{
    internal class ViewInfo
    {
        public static float number1, number2;

        public static short whichSign;

        //Standard calculator
        public static void StandardCalculator()
        {
            Console.WriteLine("\nWprowadź numer operacji, którą chcesz wykonać: " +
                              "\n\t1. Dodawanie (+)\n\t2. Odejmowanie (-)\n\t3. Mnożenie (*)" +
                              "\n\t4. Dzielenie (/)\n\t5. Pierwiastek danej liczby" +
                              "\n\t6. Potęga danej liczby\n\t7. Procent danej liczby");
            var s = Console.ReadLine();
            var canConvertSign = short.TryParse(s, out var sign);

            while (!canConvertSign)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową cyfrę/liczbę");
                Console.WriteLine("\nPodaj cyfrę/liczbę: ");
                s = Console.ReadLine();
                canConvertSign = short.TryParse(s, out sign);
            }

            if (canConvertSign)
            {
                whichSign = sign;
                switch (sign)
                {
                    case 1:
                        number1 = InsertData.insertNumber("\nPodaj pierwszą liczbę: ");
                        number2 = InsertData.insertNumber("\nPodaj drugą liczbę: ");

                        Console.WriteLine("Suma wynosi {0,2}", 
                            Calculators.add(number1, number2));
                        break;
                    case 2:
                        number1 = InsertData.insertNumber("\nPodaj pierwszą liczbę: ");
                        number2 = InsertData.insertNumber("\nPodaj drugą liczbę: ");

                        Console.WriteLine("Różnica wynosi {0,2}",
                            Calculators.sub(number1, number2));
                        break;
                    case 3:
                        number1 = InsertData.insertNumber("\nPodaj pierwszą liczbę: ");
                        number2 = InsertData.insertNumber("\nPodaj drugą liczbę: ");

                        Console.WriteLine("Iloraz wynosi {0,2}",
                            Calculators.multi(number1, number2));
                        break;
                    case 4:
                        number1 = InsertData.insertNumber("\nPodaj pierwszą liczbę: ");
                        number2 = InsertData.insertNumber("\nPodaj drugą liczbę: ");

                        if (number2 != 0)
                        {
                            Console.WriteLine("Iloczyn wynosi {0,2}",
                                Calculators.div(number1, number2));
                        }
                        else
                        {
                            Console.WriteLine("Nie można dzielić przez 0.");
                        }
                        break;
                    case 5:
                        number1 = InsertData.insertNumber("\nPodaj cyfrę/liczbę, z której chcesz obliczyć pierwiastek: ");

                        if (number1 < 0)
                            Console.WriteLine("Nie można policzyć pierwiastka z cyfry/liczby " +
                                              "ujemnej.");
                        else
                        {
                            Console.WriteLine("Pierwiastek drugiego stopnia liczby {0} wynosi {1}", 
                                number1, Calculators.square(number1));
                        }
                        break;
                    case 6:
                        number1 = InsertData.insertNumber("\nDo jakiej potęgi chcesz podnieść liczbę?: ");
                        number2 = InsertData.insertNumber("\nJaką liczbę chcesz podnieść do potęgi?: ");

                        Console.WriteLine("{0} do potęgi {1} to {2}", number2, number1, 
                            Calculators.pow(number2, number1));
                        break;
                    case 7:
                        number1 = InsertData.insertNumber("\nPodaj liczbę: ");
                        number2 = InsertData.insertNumber("\nPodaj procent, jaki chcesz obliczyć: ");

                        Console.WriteLine("{0}% z liczby {1} to {2}", 
                            number2, number1, 
                            Calculators.percent(number1, number2));
                        break;
                    default:
                        Console.WriteLine("Podaj poprawną cyfrę/liczbę.");
                        break;
                }
            }
        }

        //BMI Calculator
        public static void bmiCalculator()
        {
            number1 = InsertData.insertNumber("\nPodaj wzrost (w metrach): ");
            number2 = InsertData.insertNumber("\nPodaj masę ciała (w kg): ");

            var result = Calculators.bmi(number1, number2);

            Console.WriteLine("\nBMI osoby o wzroście {0} m i wadze {1} kg wynosi {2,2:F2}",
                number1, number2, result);
            
            if (result < 18.5)
                Console.WriteLine("Niedowaga");
            else if (result >= 18.5 && result <= 25)
                Console.WriteLine("Waga prawidłowa");
            else if (result > 25)
                Console.WriteLine("Nadwaga");
        }

        //Speed calculator
        public static void speedCalculator()
        {
            InsertDataSpeedCal.speedData();

            if (InsertDataSpeedCal.whichUnits == 1)
                Console.WriteLine("{0} km/h to {1,2:F2} m/s",
                    InsertDataSpeedCal.kilometresToMetres, Calculators.kmToM(InsertDataSpeedCal.kilometresToMetres));
            else if (InsertDataSpeedCal.whichUnits == 2)
                Console.WriteLine("{0} km/h to {1,2:F2} m/s", 
                    InsertDataSpeedCal.metresToKilometres, Calculators.mToKm(InsertDataSpeedCal.metresToKilometres));
        }

        //Figure area calculator
        public static void figureArea()
        {
            InsertDataFigureAreaCal.figureAreaData();

            if (InsertDataFigureAreaCal.WhichFigure == 1)
                Console.WriteLine("Pole kwadratu o boku {0} cm wynosi {1} cm", 
                    InsertDataFigureAreaCal.lengthA, Calculators.squareArea(InsertDataFigureAreaCal.lengthA));
            else if (InsertDataFigureAreaCal.WhichFigure == 2)
                Console.WriteLine("Pole prostokąta o bokach {0} i {1} cm wynosi {2} cm",
                    InsertDataFigureAreaCal.lengthA, InsertDataFigureAreaCal.lengthB, Calculators.rectangleArea(InsertDataFigureAreaCal.lengthA,
                        InsertDataFigureAreaCal.lengthB));
            else if (InsertDataFigureAreaCal.WhichFigure == 3)
                Console.WriteLine("Pole trójkąta o boku {0} cm i wysokości {1} wynosi {2} cm",
                    InsertDataFigureAreaCal.lengthA, InsertDataFigureAreaCal.lengthH, Calculators.triangleArea(InsertDataFigureAreaCal.lengthA,
                        InsertDataFigureAreaCal.lengthH));
            else if (InsertDataFigureAreaCal.WhichFigure == 4)
                Console.WriteLine("Pole koła o promieniu {0} cm wynosi {1} cm", InsertDataFigureAreaCal.lengthR, Calculators.circleArea(InsertDataFigureAreaCal.lengthR));
        }

        //Figure perimeter calculator
        public static void figurePerimeter()
        {
            InsertDataFigurePerimeterCal.figurePerimeterData();

            if (InsertDataFigurePerimeterCal.WhichFigure == 1)
                Console.WriteLine("Obwód kwadratu o boku {0} cm wynosi {1} cm",
                    InsertDataFigurePerimeterCal.lengthA, Calculators.squarePerimeter(InsertDataFigurePerimeterCal.lengthA));
            else if (InsertDataFigurePerimeterCal.WhichFigure == 2)
                Console.WriteLine("Obwód prostokąta o bokach {0} i {1} cm wynosi {2} cm",
                    InsertDataFigurePerimeterCal.lengthA, InsertDataFigurePerimeterCal.lengthB, Calculators.rectanglePerimeter(InsertDataFigurePerimeterCal.lengthA,
                        InsertDataFigurePerimeterCal.lengthB));
            else if (InsertDataFigurePerimeterCal.WhichFigure == 3)
                Console.WriteLine("Obwód trójkąta o bokach {0}, {1} i {2} cm wynosi {3} cm",
                    InsertDataFigurePerimeterCal.lengthA, InsertDataFigurePerimeterCal.lengthB, InsertDataFigurePerimeterCal.lengthC, Calculators.trianglePerimeter(InsertDataFigurePerimeterCal.lengthA,
                        InsertDataFigurePerimeterCal.lengthB, InsertDataFigurePerimeterCal.lengthC));
            else if (InsertDataFigurePerimeterCal.WhichFigure == 4)
                Console.WriteLine("Obwód koła o boku {0} cm wynosi {1} cm",
                    InsertDataFigurePerimeterCal.lengthR, Calculators.circlePerimeter(InsertDataFigurePerimeterCal.lengthR));
        }

        //Length calculator
        public static void length()
        {
            InsertDataLengthCal.lengthData();
            Console.WriteLine("\nPodany napis ma długość {0} znaków.", InsertDataLengthCal.Length);
        }
    }
}