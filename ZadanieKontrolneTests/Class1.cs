using ZadanieKontrolne2;
using Xunit;

namespace ZadanieKontrolneTests
{
    public class Class1
    {
        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(7, 3, 4)]
        [InlineData(-1, -3, 2)]
        public void TestMethodAdd(float result, float first, float second)
        {
            Assert.Equal(result, Calculators.add(first, second));
        }

        [Theory]
        [InlineData(1, 3, 2)]
        [InlineData(-1, 3, 4)]
        [InlineData(-5, -3, 2)]
        public void TestMethodSub(float result, float first, float second)
        {
            Assert.Equal(result, Calculators.sub(first, second));
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(12, 3, 4)]
        [InlineData(-6, -3, 2)]
        public void TestMethodMiltiple(float result, float first, float second)
        {
            Assert.Equal(result, Calculators.multi(first, second));
        }

        [Theory]
        [InlineData(5, 10, 2)]
        [InlineData(7, 28, 4)]
        [InlineData(-1, -2, 2)]
        public void TestMethodDivision(float result, float first, float second)
        {
            Assert.Equal(result, Calculators.div(first, second));
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(3, 9)]
        [InlineData(4, 16)]
        public void TestMethodSquare(float result, float number)
        {
            Assert.Equal(result, Calculators.square(number));
        }

        [Theory]
        [InlineData(3, 3, 1)]
        [InlineData(100000, 10, 5)]
        [InlineData(1, 1, 1)]
        public void TestMethodPow(float result, float number, short pow)
        {
            Assert.Equal(result, Calculators.pow(number, pow));
        }

        [Theory]
        [InlineData(100, 5, 5)]
        [InlineData(5, 50, 2.5)]
        [InlineData(10, 76, 7.6)]
        public void TestMethodPercent(float number, float percent, float result)
        {
            Assert.Equal(result, Calculators.percent(number, percent));
        }

        [Theory]
        [InlineData(21.03879026955, 1.95, 80)]
        [InlineData(21.60493827160, 1.8, 70)]
        [InlineData(18.36547291092, 1.65, 50)]
        public void TestMethodBmi(float result, float height, float weight)
        {
            Assert.Equal(result, Calculators.bmi(height, weight));
        }

        [Theory]
        [InlineData(1, 0.27777777778)]
        [InlineData(10, 2.77777777778)]
        [InlineData(100, 27.77777777778)]
        public void TestMethodMToKm(float result, float power)
        {
            Assert.Equal(result, Calculators.mToKm(power));
        }

        [Theory]
        [InlineData(1, 3.6)]
        [InlineData(10, 36.0)]
        [InlineData(100, 360.0)]
        public void TestMethodKmToM(float result, float power)
        {
            Assert.Equal(result, Calculators.kmToM(power));
        }

        [Theory]
        [InlineData(20, 5)]
        [InlineData(28, 7)]
        [InlineData(4, 1)]
        public void TestMethodSquarePerimeter(float result, float sideA)
        {
            Assert.Equal(result, Calculators.squarePerimeter(sideA));
        }

        [Theory]
        [InlineData(25, 5)]
        [InlineData(100, 10)]
        [InlineData(900, 30)]
        public void TestMethodSquareArea(float result, float sideA)
        {
            Assert.Equal(result, Calculators.squareArea(sideA));
        }

        [Theory]
        [InlineData(40, 15, 5)]
        [InlineData(80, 30, 10)]
        [InlineData(160, 60, 20)]
        public void TestMethodRectanglePerimeter(float result, float sideA, float sideB)
        {
            Assert.Equal(result, Calculators.rectanglePerimeter(sideA, sideB));
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(15, 3, 5)]
        public void TestMethodRectangleArea(float result, float sideA, float sideB)
        {
            Assert.Equal(result, Calculators.rectangleArea(sideA, sideB));
        }

        [Theory]
        [InlineData(50, 20, 20, 10)]
        [InlineData(10, 3, 2, 5)]
        [InlineData(22, 9, 8, 5)]
        public void TestMethodTrianglePerimeter(float result, float sideA, float sideB, float sideC)
        {
            Assert.Equal(result, Calculators.trianglePerimeter(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(15, 4, 7.5)]
        [InlineData(5, 5, 2)]
        [InlineData(22, 11, 4)]
        public void TestMethodTriangleArea(float result, float sideA, float sideH)
        {
            Assert.Equal(result, Calculators.triangleArea(sideA, sideH));
        }

        [Theory]
        [InlineData(25.13274122872, 4)]
        [InlineData(12.56637061436, 2)]
        [InlineData(6.28318530718, 1)]
        public void TestMethodCirclePerimeter(float result, float R)
        {
            Assert.Equal(result, Calculators.circlePerimeter(R));
        }

        [Theory]
        [InlineData(3.14159265359, 1)]
        [InlineData(6.28318530718, 2)]
        [InlineData(78.5398163397, 25)]
        public void TestMethodCircleArea(float result, float R)
        {
            Assert.Equal(result, Calculators.circleArea(R));
        }
    }
}
