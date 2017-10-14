namespace CommandPattern.Commands
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        public string CommandName => "ShipOrder";

        public string Description => CommandName;

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public ICommand MakeCommand(string[] arguments)
        {
            throw new System.NotImplementedException();
        }
    }
}
