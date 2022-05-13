using System;

namespace ZadanieKontrolne2
{
    internal class ViewInfo
    {
        public short whichSign;
        public bool canConvertSign1;

        //Standard calculator
        public void StandardCalculator()
        {
            var dataInsert = new InsertData();
            var standardCalculator = new Calculators();

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
                whichSign += sign;
                canConvertSign1 = canConvertSign;

                switch (whichSign)
                {
                    case 1:
                        dataInsert.standardData();
                        Console.WriteLine("Suma wynosi {0,2}", standardCalculator.add(dataInsert.numb1, dataInsert.numb2));
                        break;
                    case 2:
                        dataInsert.standardData();
                        Console.WriteLine("Różnica wynosi {0,2}", standardCalculator.sub(dataInsert.numb1, dataInsert.numb2));
                        break;
                    case 3:
                        dataInsert.standardData();
                        Console.WriteLine("Iloraz wynosi {0,2}", standardCalculator.multi(dataInsert.numb1, dataInsert.numb2));
                        break;
                    case 4:
                        if (dataInsert.numb2 == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez 0.");
                        }
                        else
                        {
                            dataInsert.standardData();
                            Console.WriteLine("Iloczyn wynosi {0,2}", standardCalculator.div(dataInsert.numb1, dataInsert.numb2));
                        }
                        break;
                    case 5:
                        dataInsert.squareData();
                        if (dataInsert.numbToSquare < 0)
                            Console.WriteLine("Nie można policzyć pierwiastka z cyfry/liczby ujemnej.");
                        else
                        {
                            float result = standardCalculator.square(dataInsert.numbToSquare);
                            Console.WriteLine("Pierwiastek drugiego stopnia liczby {0} wynosi {1}", dataInsert.numbToSquare, result);
                        }
                        break;
                    case 6:
                        dataInsert.powData();
                        Console.WriteLine("{0} do potęgi {1} to {2}", dataInsert.numbToPow, dataInsert.powNumb, standardCalculator.pow(dataInsert.numbToPow, dataInsert.powNumb));
                        break;
                    case 7:
                        dataInsert.percentData();
                        standardCalculator.percent(dataInsert.numb3, dataInsert.perc);
                        Console.WriteLine("{0}% z liczby {1} to {2}", dataInsert.perc, dataInsert.numb3, standardCalculator.percent(dataInsert.numb3, dataInsert.perc));
                        break;
                    default:
                        Console.WriteLine("Podaj poprawną cyfrę/liczbę.");
                        break;
                }
            }
        }

        //BMI Calculator
        public void bmiCalculator()
        {
            var data = new InsertData();
            var standardCalculator = new Calculators();

            data.bmiData();
            var result = standardCalculator.bmi(data.userHeight, data.userWeight);

            Console.WriteLine("\nBMI osoby o wzroście {0} m i wadze {1} kg wynosi {2,2:F2}", data.userHeight, data.userWeight, result);
            
            if (result < 18.5)
                Console.WriteLine("Niedowaga");
            else if (result >= 18.5 && result <= 25)
                Console.WriteLine("Waga prawidłowa");
            else if (result > 25)
                Console.WriteLine("Nadwaga");
        }

        //Speed calculator
        public void speedCalculator()
        {
            var data = new InsertData();
            var standardCalculator = new Calculators();

            data.speedData();
            
        }
    }
}
