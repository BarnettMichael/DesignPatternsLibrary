using CommandPattern.Commands;
using System.Collections.Generic;
using static System.Console;

namespace CommandPattern
{
    public class Example
    {
        public static void Run(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if (args.Length == 0)
            {
                printUsage(availableCommands);
                return;
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);

            command.Execute();
        }

        static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
            {
                new CreateOrderCommand(),
                new UpdateQuantityCommand(),
                new ShipOrderCommand(),
            };
        }

        private static void printUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            WriteLine("Usage: LoggingDemo CommandName Arguments");
            WriteLine("Commands:");
            foreach (var command in availableCommands)
            {
                WriteLine($"  {command.Description}");
            }
        }
    }
}
