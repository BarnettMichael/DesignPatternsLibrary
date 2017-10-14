using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public string CommandName => "CreateOrder";

        public string Description => CommandName;

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public ICommand MakeCommand(string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
