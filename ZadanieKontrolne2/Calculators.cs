using System;

namespace ZadanieKontrolne2
{
    internal class Calculators
    {
        //Standard calculator
        public float add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float sub(float num1, float num2)
        {
            return num1 - num2;
        }

        public float multi(float num1, float num2)
        {
            return num1 * num2;
        }

        public float div(float num1, float num2)
        {
            return num1 / num2;
        }

        public float square(float num)
        {
            return (float) Math.Sqrt(num);
        }

        public float pow(float num, short pow)
        {
            return (float) Math.Pow(num, pow);
        }

        public float percent(float num, float percent)
        {
            return (percent / 100) * num;
        }

        //BMI calculator
        public float bmi(float height, float weight)
        {
            return (float) (weight / Math.Pow(height, 2));
        }

        //Speed calculator
        public float kmToM(float speedKm)
        {
            return (float) (speedKm / 3.6);
        }

        public float mToKm(float speedM)
        {
            return (float) (speedM * 3.6);
        }

        //Figure area calculator
        public float squareArea(float lengthA)
        {
            return (float) Math.Pow(lengthA, 2);
        }

        public float rectangleArea(float lengthA, float lengthB)
        {
            return lengthA * lengthB;
        }

        public float triangleArea(float lengthA, float lengthH)
        {
            return (float) 0.5 * lengthA * lengthH;
        }

        public float circleArea(float lengthR)
        {
            return (float) Math.PI * lengthR;
        }

        //Figure perimeter calculator
        public float squarePerimeter(float lengthA)
        {
            return 4 * lengthA;
        }

        public float rectanglePerimeter(float lengthA, float lengthB)
        {
            return 2 * lengthA + 2 * lengthB;
        }

        public float trianglePerimeter(float lengthA, float lengthB, float lengthC)
        {
            return lengthA + lengthB + lengthC;
        }

        public float circlePerimeter(float lengthR)
        {
            return (float) (2 * Math.PI * lengthR);
        }

        //Length calculator
        public short length(string title)
        {
            return (short) title.Length;
        }
    }
}
