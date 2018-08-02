using MarsRovers.Models;
using MarsRovers.Services;
using Xunit;

namespace MarsRoversTest.ActionTests
{
    public class TurnLeftActionTest
    {
        [Fact]
        public void TurnLeftTest()
        {
            var marsRover = new MarsRover("5 5");
            marsRover.UpdateValues("1 2 N");
            var turnLeftAction = new TurnLeftAction();
            turnLeftAction.Action(marsRover);
            Assert.Equal("1 2 W", marsRover.RunAndGetResult());
        }
    }
}
