using MarsRovers.Models;
using MarsRovers.Services;
using Xunit;

namespace MarsRoversTest.ActionTests
{
    public class TurnRightActionTest
    {
        [Fact]
        public void TurnRightTest()
        {
            var marsRover = new MarsRover("5 5");
            marsRover.UpdateValues("1 2 N");
            var turnRightAction = new TurnRightAction();
            turnRightAction.Action(marsRover);
            Assert.Equal("1 2 E", marsRover.RunAndGetResult());
        }
    }
}
