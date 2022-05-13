using System;

namespace ZadanieKontrolne2
{
    internal class Program
    {
        static void Calculator()
        {
            Console.WriteLine("\nDo jakiego kalkulatora chcesz przejść?:" +
                              "\n\t1. Zwykłego/naukowego,\n\t2. BMI,\n\t3. Prędkości," +
                              "\n\t4. Obliczającego pole figury,\n\t5. Obliczającego obwód figury," +
                              "\n\t6. Obliczającego ilość znaków w napisie.");
            var kOC = Console.ReadLine();
            var canConvertKindOfCalculator = short.TryParse(kOC, out var kindOfCalculator);

            if (canConvertKindOfCalculator)
            {
                switch (kindOfCalculator)
                {
                    case 1:
                        ViewInfo.StandardCalculator();
                        break;
                    case 2:
                        ViewInfo.bmiCalculator();
                        break;
                    case 3:
                        ViewInfo.speedCalculator();
                        break;
                    case 4:
                        ViewInfo.figureArea();
                        break;
                    case 5:
                        ViewInfo.figurePerimeter();
                        break;
                    case 6:
                        ViewInfo.length();
                        break;
                    default:
                        Console.WriteLine("Podano niepoprawną wartość.");
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
