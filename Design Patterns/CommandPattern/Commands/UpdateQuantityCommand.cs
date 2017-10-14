using static System.Console;

namespace CommandPattern.Commands
{
    class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public string CommandName => "UpdateQuantity";

        public string Description => "UpdateQuantity number";

        public void Execute()
        {
            // simulate updating a database
            const int oldQuantity = 5;
            WriteLine("DATABASE: Updated");

            //simulate logging
            WriteLine($"LOG: Updated order quantity from {oldQuantity} to {NewQuantity}");
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new UpdateQuantityCommand()
            {
                NewQuantity = int.Parse(arguments[1])
            };
        }
    }
}
