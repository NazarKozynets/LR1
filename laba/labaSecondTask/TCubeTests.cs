using System;
using Xunit;
using LabaSecondTask;

namespace LabaSecondTask
{
    public class TCubeTests
    {
        [Fact]
        public void Constructor_Default_ShouldSetSideToZero()
        {
            var cube = new TCube();
            Assert.Equal(0, cube.CalculateArea());
        }

        [Fact]
        public void Constructor_WithSide_ShouldSetSide()
        {
            var cube = new TCube(3);
            Assert.Equal(27, cube.CalculateArea());
        }

        [Fact]
        public void Constructor_Copy_ShouldCopySide()
        {
            var original = new TCube(4);
            var copy = new TCube(original);
            Assert.Equal(original.CalculateArea(), copy.CalculateArea());
        }

        [Fact]
        public void CalculateVolume_ShouldReturnCorrectValue()
        {
            var cube = new TCube(3);
            Assert.Equal(27, cube.CalculateArea());
        }

        [Fact]
        public void ToString_ShouldReturnCorrectString()
        {
            var cube = new TCube(2);
            var result = cube.ToString();
            Assert.Equal("Cube: Side = 2, Area = 4, Perimeter = 8, Volume = 8", result);
        }
    }
}