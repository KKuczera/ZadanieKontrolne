using System;

namespace ZadanieKontrolne2
{
    internal class Program
    {
        static void Calculator()
        {
            var calculator = new ViewInfo();
            Console.WriteLine("\nDo jakiego kalkulatora chcesz przejść?:" +
                              "\n\t1. Zwykłego/naukowego,\n\t2. BMI,\n\t3. Prędkości," +
                              "\n\t4. Obliczającego pole figury,\n\t5. Obliczającego obwód figury," +
                              "\n\t6. Obliczającego ilość znaków w napisie,\n\t7. Obliczającego" +
                              "różnicę czasu.");
            var kOC = Console.ReadLine();
            var canConvertkOC = short.TryParse(kOC, out var kindOfCalculator);

            if (canConvertkOC)
            {
                switch (kindOfCalculator)
                {
                    case 1:
                        calculator.standardCalculator();
                        break;
                    case 2:
                        calculator.bmiCalculator();
                        break;
                    case 3:
                        Console.WriteLine("csadas");

                        //speed();
                        break;
                    case 4:
                        Console.WriteLine("csadas");

                        //figureArea();
                        break;
                    case 5:
                        Console.WriteLine("csadas");

                        //figurePerimeter();
                        break;
                    case 6:
                        Console.WriteLine("csadas");

                        //length();
                        break;
                    case 7:
                        Console.WriteLine("csadas");

                        //time();
                        break;
                    default:
                        Console.WriteLine("Podaj poprawną cyfrę, żeby przejść do odpowiedniego kalkulatora.");
                        break;
                }
            }
            else
                Console.WriteLine("Podano nieprawidłową wartość.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Czy chcesz skorzystać z kalkulatora? (t/n): ");
            var yesOrNo = Console.ReadLine();

            while (true)
            {
                switch (yesOrNo)
                {
                    case "t":
                        Calculator();

                        Console.WriteLine("\nCzy chcesz skorzystać z kalkulatora? (t/n): ");
                        yesOrNo = Console.ReadLine();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
