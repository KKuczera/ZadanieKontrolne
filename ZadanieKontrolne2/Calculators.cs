using System;

namespace ZadanieKontrolne
{
    public class Calculators
    {
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
    }
}
