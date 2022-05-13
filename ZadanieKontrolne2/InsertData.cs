using System;

namespace ZadanieKontrolne2
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

        /*public static void insertNumber2()
        {
            Console.WriteLine("\nWprowadź liczbę: ");
            var num2 = Console.ReadLine();
            var canConvertNumber1 = float.TryParse(num2, out var number2);

            while (!canConvertNumber1)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową cyfrę/liczbę");
                Console.WriteLine("\nPodaj cyfrę/liczbę: ");
                num2 = Console.ReadLine();
                canConvertNumber1 = float.TryParse(num2, out number2);
            }

            if (canConvertNumber1)
            {
                numb2 = number2;
                canConvertNumb2 = canConvertNumber1;
            }
        }

        //Insert data for standard calculator
        /*public static void standardData()
        {
            Console.WriteLine("\nWprowadź liczbę 1: ");
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

            Console.WriteLine("\nWprowadź liczbę 2: ");
            var num2 = Console.ReadLine();
            var canConvertNumber2 = float.TryParse(num2, out var number2);

            while (!canConvertNumber2)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową cyfrę/liczbę");
                Console.WriteLine("\nPodaj cyfrę/liczbę: ");
                num2 = Console.ReadLine();
                canConvertNumber2 = float.TryParse(num2, out number2);
            }

            if (canConvertNumber2)
            {
                numb2 = number2;
                canConvertNumb2 = canConvertNumber2;
            }
        }*/

        //Insert data for calculate square of number
        /*public static void squareData()
        {
            Console.WriteLine("\nZ jakiej liczby chcesz obliczyć pierwiastek?: ");
            var squareNumber = Console.ReadLine();
            var canConvertSquare = float.TryParse(squareNumber,
                out var numberToSquare);

            while (!canConvertSquare || numberToSquare < 0)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę.");
                Console.WriteLine("\nPodaj cyfrę: ");
                squareNumber = Console.ReadLine();
                canConvertSquare = float.TryParse(squareNumber,
                    out numberToSquare);
            }

            if (canConvertSquare)
            {
                canConvertNumbToSquare = canConvertSquare;
                numbToSquare = numberToSquare;
            }
        }

        //Insert data for calculate a pow of number
        public static void powData()
        {
            Console.WriteLine("\nJaką cyfrę/liczbę chcesz podnieść do potęgi?: ");
            var number = Console.ReadLine();
            var canConvertNum =float.TryParse(number, out var numberForPow);

            while (!canConvertNum)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę");
                Console.WriteLine("\nKtórą cyfrę/liczbę chcesz podnieść do" +
                                  " potęgi? (1/2): ");
                number = Console.ReadLine();
                canConvertNum = float.TryParse(number, out numberForPow);
            }

            Console.WriteLine("Do jakiej potęgi chcesz podnieść podaną cyfrę/liczbę?: ");
            var pow = Console.ReadLine();
            var canConvertPow = short.TryParse(pow, out var whichPow);

            while (!canConvertPow || whichPow < 0)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę");
                Console.WriteLine("\nKtórą cyfrę/liczbę chcesz podnieść do" +
                                  " potęgi? (1/2): ");
                pow = Console.ReadLine();
                canConvertPow = short.TryParse(pow, out whichPow);
            }

            if (canConvertNum && canConvertPow)
            {
                numbToPow = numberForPow;
                powNumb = whichPow;
            }
        }

        //Insert data for calculate a percent of number
        public static void percentData()
        {
            Console.WriteLine("\nZ jakiej liczby chcesz obliczyć procent?: ");
            var number = Console.ReadLine();
            var canConvertNum = float.TryParse(number, out var numberForPercent);

            while (!canConvertNum || numberForPercent < 0)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę");
                Console.WriteLine("\nZ jakiej liczby chcesz obliczyć procent?: ");
                number = Console.ReadLine();
                canConvertNum = float.TryParse(number, out numberForPercent);
            }

            Console.WriteLine("\nJaki procent chcesz obliczyć?: ");
            var percent = Console.ReadLine();
            var canConvertPercent = short.TryParse(percent, out var howMuchPercent);

            while (!canConvertPercent || howMuchPercent < 0)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę");
                Console.WriteLine("\nJaki procent chcesz obliczyć?: ");
                percent = Console.ReadLine();
                canConvertPercent = short.TryParse(percent, out howMuchPercent);
            }

            if (canConvertNum && canConvertPercent)
            {
                numb3 = numberForPercent;
                perc = howMuchPercent;
            }
        }*/
    }
}
