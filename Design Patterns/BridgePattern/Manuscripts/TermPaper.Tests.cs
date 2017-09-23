using BridgePattern.Formatters;
using NUnit.Framework;
using Shouldly;
using System;
using System.IO;
using System.Linq;
using static System.Console;

namespace BridgePattern.Manuscripts
{
    [TestFixture]
    public class TermPaperTests
    {
        public class PrintShould
        {
            [Test]
            [TestCase("", "", "", "")]
            [TestCase("class", "student", "text", "references")]
            [TestCase("Physics", "Jane Doe", "e=mc^2", "Einstein")]
            [TestCase("English", "Bert", "Iambic Pentameter", "Shakespeare")]
            [TestCase("Dentistry", "Smiley Joe", "Tooth B Gone", "Dentistry for kids")]
            public void WithAFormatter_ShouldPrintAFormattedStringOfProperties(string @class, string student, string text, string references)
            {
                //Arrange
                var sut = new TermPaper(new StandardFormatter());
                sut.Class = @class;
                sut.Student = student;
                sut.Text = text;
                sut.References = references;

                //Act
                using (var consoleText = new StringWriter())
                {
                    SetOut(consoleText);
                    sut.Print();
                    //Assert
                    consoleText.ToString().ShouldSatisfyAllConditions(new Action[]
                    {
                    () => consoleText.ToString().ShouldContain(@class),
                    () => consoleText.ToString().ShouldContain(student),
                    () => consoleText.ToString().ShouldContain(text),
                    () => consoleText.ToString().ShouldContain(references),
                    () => consoleText.ToString().Count(c => c == Environment.NewLine.First()).ShouldBe(5)
                    });
                }
            }

        }
    }
}
