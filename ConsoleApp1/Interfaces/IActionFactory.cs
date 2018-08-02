namespace ConsoleApp1.Interfaces
{
    public interface IActionFactory
    {
        IAction GetActionByType(char actionType);
    }
}
