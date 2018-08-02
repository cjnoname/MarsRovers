using MarsRovers.Models;
using Xunit;

namespace MarsRoversTest.ModelTests
{
    public class CoordinatesTest
    {
        [Fact]
        public void Test1()
        {
            var coordinates = new Coordinates(1, 3);
            (int x, int y) = coordinates.AfterOffset(-1, 0);
            Assert.Equal(0, x);
            Assert.Equal(3, y);
        }

        [Fact]
        public void Test2()
        {
            var coordinates = new Coordinates(1, 3);
            coordinates.UpdateCoordinates(5, 6);
            Assert.Equal("5 6", coordinates.ToString());
        }
    }
}
