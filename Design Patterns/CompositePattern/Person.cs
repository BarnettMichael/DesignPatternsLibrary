using static System.Console;

namespace CompositePattern
{
    public class Person : IParty
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            WriteLine($"{Name} has {Gold} gold coins.");
        }
    }
}
