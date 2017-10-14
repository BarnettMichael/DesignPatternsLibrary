using static System.Console;

namespace CommandPattern.Commands
{
    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            WriteLine($"Couldn't find command: {Name}");
        }
    }
}
