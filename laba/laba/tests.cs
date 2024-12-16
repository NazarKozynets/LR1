using System;
using Xunit;

namespace Laba
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_ValidSides_CreatesTriangle()
        {
            float a = 3.0f;
            float b = 4.0f;
            float c = 5.0f;

            var triangle = new Triangle(a, b, c);

            Assert.NotNull(triangle);
        }

        [Fact]
        public void Triangle_NegativeSide_ThrowsArgumentException()
        {
            float a = -3.0f;
            float b = 4.0f;
            float c = 5.0f;

            var exception = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
            Assert.Equal("Sides of a triangle must be positive numbers greater than zero.", exception.Message);
        }

        [Fact]
        public void Triangle_Indexer_ReturnsCorrectSides()
        {
            var triangle = new Triangle(3.0f, 4.0f, 5.0f);

            float sideA = triangle[0];
            float sideB = triangle[1];
            float sideC = triangle[2];

            Assert.Equal(3.0f, sideA);
            Assert.Equal(4.0f, sideB);
            Assert.Equal(5.0f, sideC);
        }

        [Fact]
        public void Triangle_CalculatePerimeter_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3.0f, 4.0f, 5.0f);

            float perimeter = triangle.CalculatePerimeter();

            Assert.Equal(12.0f, perimeter);
        }

        [Fact]
        public void Triangle_GetArea_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3.0f, 4.0f, 5.0f);

            float area = triangle.GetArea();

            Assert.Equal(6.0f, area, 1); // 6.0f with a precision of 1 decimal place
        }
    }
}
