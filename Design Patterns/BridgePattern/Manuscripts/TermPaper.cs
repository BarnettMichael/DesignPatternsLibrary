using BridgePattern.Interfaces;
using static System.Console;
namespace BridgePattern.Manuscripts
{
    public class TermPaper : Manuscript
    {
        public TermPaper(IFormatter formatter) : base(formatter) { }

        public string Class { get; internal set; }
        public string Student { get; internal set; }
        public string Text { get; internal set; }
        public string References { get; internal set; }

        public override void Print()
        {
            WriteLine(formatter.Format("Class", Class));
            WriteLine(formatter.Format("Student", Student));
            WriteLine(formatter.Format("Text", Text));
            WriteLine(formatter.Format("References", References));
            WriteLine();
        }
    }
}