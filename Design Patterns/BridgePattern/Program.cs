using BridgePattern.Formatters;
using BridgePattern.Manuscripts;
using System.Collections.Generic;
using static System.Console;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new List<Manuscript>();
            var standardFormatter = new StandardFormatter();
            var reverseFormatter = new ReverseFormatter();
            var fancyFormatter = new FancyFormatter();

            var faq = new FAQ(standardFormatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern.");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book(fancyFormatter)
            {
                Title = "Lots of patterns",
                Author = "John Sonmez",
                Text = "Blah Blah Blah..."
            };
            documents.Add(book);
            var paper = new TermPaper(reverseFormatter)
            {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah Blah Blah...",
                References = "GOF"
            };
            documents.Add(paper);

            documents.ForEach(m => m.Print());
            ReadKey();
        }
    }
}
