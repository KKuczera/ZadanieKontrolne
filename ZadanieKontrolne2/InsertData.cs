using System;

namespace ZadanieKontrolne2
{
    internal class InsertData
    {
        public float numb1, numb2, numb3, userWeight, userHeight, speedM, speedKm;
        public short perc, numbToSquare, powNumb, numbToPow, whichUnits;
        public bool canConvertNumb1, canConvertNumb2, canConvertNumbToSquare, 
            canConvertWeight, CanConvertHeight;

        //Insert data for standard calculator
        public void standardData()
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
                numb1 += number1;
                canConvertNumb1 = canConvertNumber1;
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
                numb2 += number2;
                canConvertNumb2 = canConvertNumber2;
            }
        }

        //Insert data for calculate square of number
        public void squareData()
        {
            Console.WriteLine("\nZ jakiej liczby chcesz obliczyć pierwiastek?: ");
            var squareNumber = Console.ReadLine();
            var canConvertSquare = short.TryParse(squareNumber,
                out var square);

            while (!canConvertSquare)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę.");
                Console.WriteLine("\nPodaj cyfrę: ");
                squareNumber = Console.ReadLine();
                canConvertSquare = short.TryParse(squareNumber,
                    out square);
            }

            if (canConvertSquare)
            {
                canConvertNumbToSquare = canConvertSquare;
                numbToSquare = square;
            }
        }

        //Insert data for calculate a pow of number
        public void powData()
        {
            var calculator = new Calculators();

            Console.WriteLine("\nJaką cyfrę/liczbę chcesz podnieść do potęgi?: ");
            var number = Console.ReadLine();
            var canConvertNum = short.TryParse(number, out var numberForPow);

            while (!canConvertNum)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę");
                Console.WriteLine("\nKtórą cyfrę/liczbę chcesz podnieść do" +
                                  " potęgi? (1/2): ");
                number = Console.ReadLine();
                canConvertNum = short.TryParse(number, out numberForPow);
            }

            Console.WriteLine("Do jakiej potęgi chcesz podnieść podaną cyfrę/liczbę?: ");
            var pow = Console.ReadLine();
            var canConvertPow = short.TryParse(pow, out var whichPow);

            while (!canConvertPow)
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
        public void percentData()
        {
            var calculator = new Calculators();
            
            Console.WriteLine("\nZ jakiej liczby chcesz obliczyć procent?: ");
            var number = Console.ReadLine();
            var canConvertNum = short.TryParse(number, out var numberForPercent);

            while (!canConvertNum)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę");
                Console.WriteLine("\nKtórą cyfrę/liczbę chcesz podnieść do" +
                                  " potęgi? (1/2): ");
                number = Console.ReadLine();
                canConvertNum = short.TryParse(number, out numberForPercent);
            }

            Console.WriteLine("Jaki procent chcesz obliczyć?: ");
            var percent = Console.ReadLine();
            var canConvertPercent = short.TryParse(percent, out var howMuchPercent);

            while (!canConvertPercent)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!" +
                                  "\nProszę wprowadzić prawidłową " +
                                  "cyfrę");
                Console.WriteLine("\nKtórą cyfrę/liczbę chcesz podnieść do" +
                                  " potęgi? (1/2): ");
                percent = Console.ReadLine();
                canConvertPercent = short.TryParse(percent, out howMuchPercent);
            }

            if (canConvertNum && canConvertPercent)
            {
                numb3 = numberForPercent;
                perc = howMuchPercent;
            }
        }

        //Insert data for calculate BMI
        public void bmiData()
        {
            Console.WriteLine("\nWprowadź wzrost (w metrach): ");
            var height = Console.ReadLine();
            var canConvertH = float.TryParse(height, out var h);

            while (!canConvertH)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj długość boku: ");
                height = Console.ReadLine();
                canConvertH = float.TryParse(height, out h);
            }

            Console.WriteLine("Wprowadź masę ciała (w kg): ");
            var weight = Console.ReadLine();
            var canConvertW = float.TryParse(weight, out var w);

            while (!canConvertW)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj długość boku: ");
                weight = Console.ReadLine();
                canConvertW = float.TryParse(weight, out w);
            }

            if (canConvertH && canConvertW)
            {
                CanConvertHeight = canConvertH;
                canConvertWeight = canConvertW;
                userHeight = h;
                userWeight = w;
            }
        }

        public void speedData()
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
                switch (units)
                {
                    case 1:
                        Console.WriteLine("\nPodaj prędkość w km/h:");
                        var speed_kilometresmetres = Console.ReadLine();
                        var canConvertSpeedKM = float.TryParse(speed_kilometresmetres, out var speedInKilometres);

                        while (!canConvertSpeedKM)
                        {
                            Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                              "wprowadzić prawidłową prędkość.");
                            Console.WriteLine("\nPodaj prędkość: ");
                            speed_kilometresmetres = Console.ReadLine();
                            canConvertSpeedKM = float.TryParse(speed_kilometresmetres, out speedInKilometres);
                        }

                        if (canConvertSpeedKM)
                        {
                            var speedMetresToKilometres = (float)(speedInKilometres * (1000 * 3600));

                            Console.WriteLine("{0} m/s to w przybliżeniu {1,1:F2} km/h",
                                speedInKilometres, speedMetresToKilometres);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nPodaj prędkość w m/s:");
                        var speed_metres = Console.ReadLine();
                        var canConvertSpeedM = float.TryParse(speed_metres, out var speedInMetres);

                        while (!canConvertSpeedM)
                        {
                            Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                              "wprowadzić prawidłową prędkość.");
                            Console.WriteLine("\nPodaj prędkość: ");
                            speed_metres = Console.ReadLine();
                            canConvertSpeedM = float.TryParse(speed_metres, out speedInMetres);
                        }

                        if (canConvertSpeedM)
                        {
                            speedM = speedInMetres;
                            
                            /*var speedMetresToKilometres = (float)(speedInMetres * (0.001 * 3600));

                            Console.WriteLine("{0} m/s to w przybliżeniu {1,1:F2} km/h",
                                speedInMetres, speedMetresToKilometres);*/
                        }
                        break;
                }
            }
        }
    }
}
