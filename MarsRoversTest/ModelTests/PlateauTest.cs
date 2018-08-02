using MarsRovers.Models;
using Xunit;

namespace MarsRoversTest.ModelTests
{
    public class PlateauTest
    {
        [Fact]
        public void Test1()
        {
            var plateau = new Plateau(5,5);
            Assert.True(plateau.InBound(3,4));
        }

        [Fact]
        public void Test2()
        {
            var plateau = new Plateau(5, 5);
            Assert.True(plateau.InBound(5, 5));
        }

        [Fact]
        public void Test3()
        {
            var plateau = new Plateau(5, 5);
            Assert.False(plateau.InBound(5, 6));
        }

        [Fact]
        public void Test4()
        {
            var plateau = new Plateau(5, 5);
            Assert.False(plateau.InBound(8, 3));
        }

        [Fact]
        public void Test5()
        {
            var plateau = new Plateau(5, 5);
            Assert.False(plateau.InBound(-1, 3));
        }

        [Fact]
        public void Test6()
        {
            var plateau = new Plateau(5, 5);
            Assert.False(plateau.InBound(5, -1));
        }
    }
}
