using FigureLibrary.Figures;

namespace FigureLibrary.Tests
{
    public class UnitTest1
    {
        private double precision = 0.0001;

        [Fact]
        public void Test1()
        {
            double area = Figure.GetArea("FigureLibrary.Figures.Circle", 5.0);
            Assert.Equal(78.53981, area, precision);
        }

        [Theory]
        [InlineData(2.0, 3.0, -3.0)]
        [InlineData(0.0, 1.0, 2.0)]
        [InlineData(0.0, -1.0, -2.0)]
        [InlineData(4.0, 0.0, 4.0)]
        [InlineData(3.0, 4.0, 8.0)]
        public void TriangleConstructor_ShouldThrow_ArgumentException_WhenSideLength_IsIncorrect(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(a, b, c);
            });
        }

        [Theory]
        [InlineData("NonExistentFigure")]
        [InlineData("adfsfsofsn")]
        public void StaticGetAreaMethod_ShouldThrow_ArgumentException_WhenProvidedType_DoesNotExist(string incorrectType)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Figure.GetArea(incorrectType);
            });
        }

        [Theory]
        [InlineData(-5.0)]
        [InlineData(0.0)]
        public void CircleConstructor_ShouldThrow_ArgumentException_WhenRadius_IsNotPositive(double r)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Circle(r);
            });
        }

        [Theory]
        [InlineData(7.0, 153.93804)]
        [InlineData(5.3, 88.24734)]
        public void CircleArea_ShouldBe_Expected(double r, double expectedArea)
        {
            var circle = new Circle(r);

            Assert.Equal(expectedArea, circle.GetArea(), precision);
        }

        [Theory]
        [InlineData(7.0, 9.0, 12.0, 31.304952)]
        [InlineData(25.0, 47.0, 32.0, 374.69988)]
        public void TriangleArea_ShouldBe_Expected(double a, double b, double c, double expectedArea)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(expectedArea, triangle.GetArea(), precision);
        }

        [Theory]
        [InlineData(3.0, 4.0, 5.0)]
        [InlineData(5.0, 12.0, 13.0)]
        public void Triangle_ShouldBe_Rectangular(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsRectangular());
        }
    }
}