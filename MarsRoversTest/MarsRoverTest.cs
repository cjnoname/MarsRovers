using MarsRovers.Factories;
using MarsRovers.Models;
using Xunit;

namespace MarsRoversTest.OutputTest
{
    public class MarsRoverTest
    {
        [Fact]
        public void Test1()
        {
            string plateauInput = "5 5";
            string initialStateInput = "1 2 N";
            string commandLineInput = "LMLMLMLMM";
            var marsRover = new MarsRover(plateauInput);
            var actionFactory = new ActionFactory();
            marsRover.UpdateValues(initialStateInput, commandLineInput);
            Assert.Equal("1 3 N", marsRover.RunAndGetResult(actionFactory));
        }

        [Fact]
        public void Test2()
        {
            string plateauInput = "5 5";
            string initialStateInput = "3 3 E";
            string commandLineInput = "MMRMMRMRRM";
            var marsRover = new MarsRover(plateauInput);
            var actionFactory = new ActionFactory();
            marsRover.UpdateValues(initialStateInput, commandLineInput);
            Assert.Equal("5 1 E", marsRover.RunAndGetResult(actionFactory));
        }

        [Fact]
        public void Test3()
        {
            string plateauInput = "5 5";
            string initialStateInput = "3 3 E";
            string commandLineInput = "MMRMMRMRRM";
            var marsRover = new MarsRover(plateauInput);
            var actionFactory = new ActionFactory();
            marsRover.UpdateValues(initialStateInput, commandLineInput);
            Assert.Equal("5 1 E", marsRover.RunAndGetResult(actionFactory));
        }

        [Fact]
        public void Test4()
        {
            string plateauInput = "5 5";
            string initialStateInput = "3 3 N";
            string commandLineInput = "MMMMMMMMMMR";
            var marsRover = new MarsRover(plateauInput);
            var actionFactory = new ActionFactory();
            marsRover.UpdateValues(initialStateInput, commandLineInput);
            Assert.Equal("3 5 E", marsRover.RunAndGetResult(actionFactory));
        }

        [Fact]
        public void Test5()
        {
            string plateauInput = "5 5";
            string initialStateInput = "1 2 N";
            var marsRover = new MarsRover(plateauInput);
            var actionFactory = new ActionFactory();
            marsRover.UpdateValues(initialStateInput);
            marsRover.TurnLeft();
            Assert.Equal("1 2 W", marsRover.RunAndGetResult(actionFactory));
        }

        [Fact]
        public void Test6()
        {
            string plateauInput = "5 5";
            string initialStateInput = "1 2 N";
            var marsRover = new MarsRover(plateauInput);
            var actionFactory = new ActionFactory();
            marsRover.UpdateValues(initialStateInput);
            marsRover.TurnRight();
            Assert.Equal("1 2 E", marsRover.RunAndGetResult(actionFactory));
        }

        [Fact]
        public void Test7()
        {
            string plateauInput = "5 5";
            string initialStateInput = "1 2 N";
            var marsRover = new MarsRover(plateauInput);
            var actionFactory = new ActionFactory();
            marsRover.UpdateValues(initialStateInput);
            marsRover.Move();
            Assert.Equal("1 3 N", marsRover.RunAndGetResult(actionFactory));
        }
    }
}
