using BridgePattern.Interfaces;
using System.Collections.Generic;
using static System.Console;

namespace BridgePattern.Manuscripts
{
    public class FAQ : Manuscript
    {
        public string Title { get; internal set; }
        public Dictionary<string, string> Questions = new Dictionary<string, string>();
        public FAQ(IFormatter formatter) : base(formatter) { }

        public override void Print()
        {
            WriteLine($"Title: {Title}");
            foreach (var question in Questions)
            {
                WriteLine(formatter.Format("    Question", question.Key));
                WriteLine(formatter.Format("    Answer", question.Value));
            }
            WriteLine();
        }
    }
}
