using System;

namespace ZadanieKontrolne2
{
    public class Calculators
    {
        //static short YearDifference, MonthDifference, DayDifference;

        public static float add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float sub(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float multi(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float div(float num1, float num2)
        {
            return num1 / num2;
        }

        public static float square(float num)
        {
            return (float) Math.Sqrt(num);
        }

        public static float pow(float num, float pow)
        {
            return (float) Math.Pow(num, pow);
        }

        public static float percent(float num, float percent)
        {
            return (percent / 100) * num;
        }

        //BMI calculator
        public static float bmi(float height, float weight)
        {
            return (float) (weight / Math.Pow(height, 2));
        }

        //Speed calculator
        public static float kmToM(float speedKm)
        {
            return (float) (speedKm / 3.6);
        }

        public static float mToKm(float speedM)
        {
            return (float) (speedM * 3.6);
        }

        //Figure area calculator
        public static float squareArea(float lengthA)
        {
            return (float) Math.Pow(lengthA, 2);
        }

        public static float rectangleArea(float lengthA, float lengthB)
        {
            return lengthA * lengthB;
        }

        public static float triangleArea(float lengthA, float lengthH)
        {
            return (float) 0.5 * lengthA * lengthH;
        }

        public static float circleArea(float lengthR)
        {
            return (float) (Math.PI * Math.Pow(lengthR, 2));
        }

        //Figure perimeter calculator
        public static float squarePerimeter(float lengthA)
        {
            return 4 * lengthA;
        }

        public static float rectanglePerimeter(float lengthA, float lengthB)
        {
            return 2 * lengthA + 2 * lengthB;
        }

        public static float trianglePerimeter(float lengthA, float lengthB, float lengthC)
        {
            return lengthA + lengthB + lengthC;
        }

        public static float circlePerimeter(float lengthR)
        {
            return (float) (2 * Math.PI * lengthR);
        }

        //Length calculator
        public static short length(string writing)
        {
            return (short) writing.Length;
        }

        /*public void CalcDateDelta(bool canConvertYear, bool canConvertMonth, bool canConvertDay, short month, short day,
            DateTime thisDate, short year)
        {
            if (canConvertYear && canConvertMonth && canConvertDay)
            {
                if (month >= 1 && month <= 12 && day >= 1 && day <= 31)
                {
                    const short daysMax = 31;
                    const short daysMin = 1;
                    const short monthsMax = 12;
                    const int monthsMin = 1;

                    var yearDifference = (short)(thisDate.Year - year);
                    var monthDifference = (short)(thisDate.Month - month);
                    var dayDifference = (short)(thisDate.Day - day);

                    if (dayDifference < 0)
                    {
                        monthDifference--;
                        dayDifference *= -1;
                        dayDifference = (short)(daysMax - dayDifference - 1);
                    }

                    if (dayDifference > 31)
                    {
                        monthDifference++;
                        dayDifference = (short)(daysMin + dayDifference - 1);
                    }

                    if (monthDifference < 0)
                    {
                        yearDifference--;
                        monthDifference *= -1;
                        monthDifference = (short)(monthsMax - monthDifference);
                    }

                    if (monthDifference > 12)
                    {
                        yearDifference++;
                        monthDifference = (short)(monthsMin + monthDifference);
                    }

                    var Year = yearDifference;
                    var Month = monthDifference;
                    var Day = dayDifference;
                }
            }
            
        }*/
    }
}
