using MarsRovers.Models;
using MarsRovers.Services;
using Xunit;

namespace MarsRoversTest.ActionTests
{
    public class MoveActionTest
    {
        [Fact]
        public void MoveTest()
        {
            var marsRover = new MarsRover("5 5");
            marsRover.UpdateValues("1 2 N");
            var moveAction = new MoveAction();
            moveAction.Action(marsRover);
            Assert.Equal("1 3 N", marsRover.RunAndGetResult());
        }
    }
}
