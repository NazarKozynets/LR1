using System;
using Xunit;

namespace LabaSecondTask
{
    public class TSquareTests
    {
        [Fact]
        public void Constructor_Default_ShouldSetSideToZero()
        {
            var square = new TSquare();
            Assert.Equal(0, square.CalculateArea());
            Assert.Equal(0, square.CalculatePerimeter());
        }

        [Fact]
        public void Constructor_WithSide_ShouldSetSide()
        {
            var square = new TSquare(5);
            Assert.Equal(5 * 5, square.CalculateArea());
            Assert.Equal(4 * 5, square.CalculatePerimeter());
        }

        [Fact]
        public void Constructor_Copy_ShouldCopySide()
        {
            var original = new TSquare(3);
            var copy = new TSquare(original);
            Assert.Equal(original.CalculateArea(), copy.CalculateArea());
            Assert.Equal(original.CalculatePerimeter(), copy.CalculatePerimeter());
        }

        [Fact]
        public void CalculateArea_ShouldReturnCorrectValue()
        {
            var square = new TSquare(4);
            Assert.Equal(16, square.CalculateArea());
        }

        [Fact]
        public void CalculatePerimeter_ShouldReturnCorrectValue()
        {
            var square = new TSquare(4);
            Assert.Equal(16, square.CalculatePerimeter());
        }

        [Fact]
        public void ToString_ShouldReturnCorrectString()
        {
            var square = new TSquare(3);
            var result = square.ToString();
            Assert.Equal("Square: Side = 3, Area = 9, Perimeter = 12", result);
        }

        [Fact]
        public void Operator_Add_ShouldAddSides()
        {
            var square1 = new TSquare(2);
            var square2 = new TSquare(3);
            var result = square1 + square2;
            Assert.Equal(5, result.CalculatePerimeter() / 4);
        }

        [Fact]
        public void Operator_Subtract_ShouldSubtractSides()
        {
            var square1 = new TSquare(5);
            var square2 = new TSquare(3);
            var result = square1 - square2;
            Assert.Equal(2, result.CalculatePerimeter() / 4);
        }

        [Fact]
        public void Operator_Multiply_ShouldScaleSide()
        {
            var square = new TSquare(3);
            var result = square * 2;
            Assert.Equal(6, result.CalculatePerimeter() / 4);
        }
    }
}
