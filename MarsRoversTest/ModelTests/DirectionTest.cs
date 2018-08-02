using MarsRovers.Enums;
using MarsRovers.Models;
using Xunit;

namespace MarsRoversTest.ModelTests
{
    public class DirectionTest
    {
        [Fact]
        public void Test1()
        {
            var direction = new Direction(DirectionType.E);
            direction.TurnRight();
            Assert.Equal(DirectionType.S, direction.CurrentDirection);
        }

        [Fact]
        public void Test2()
        {
            var direction = new Direction(DirectionType.W);
            direction.TurnRight();
            Assert.Equal(DirectionType.N, direction.CurrentDirection);
        }

        [Fact]
        public void Test3()
        {
            var direction = new Direction(DirectionType.N);
            direction.TurnLeft();
            Assert.Equal(DirectionType.W, direction.CurrentDirection);
        }

        [Fact]
        public void Test4()
        {
            var direction = new Direction(DirectionType.S);
            direction.TurnLeft();
            Assert.Equal(DirectionType.E, direction.CurrentDirection);
        }

        [Fact]
        public void Test5()
        {
            var direction = new Direction(DirectionType.S);
            Assert.Equal((0, -1), direction.GetOffset());
        }

        [Fact]
        public void Test6()
        {
            var direction = new Direction(DirectionType.W);
            Assert.Equal("W", direction.ToString());
        }
    }
}
