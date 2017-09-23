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
    public class FAQTests
    {
        public class PrintShould
        {
            [Test]
            [TestCase("", "", "")]
            [TestCase("title", "question", "answer")]
            public void WithAFormatter_ShouldPrintAFormattedStringOfProperties(string title, string key, string value)
            {
                //Arrange
                var sut = new FAQ(new StandardFormatter());
                sut.Title = title;
                sut.Questions.Add(key, value);

                //Act
                using (var consoleText = new StringWriter())
                {
                    SetOut(consoleText);
                    sut.Print();
                    //Assert
                    consoleText.ToString().ShouldSatisfyAllConditions(new Action[]
                    {
                    () => consoleText.ToString().ShouldContain(title),
                    () => consoleText.ToString().ShouldContain(key),
                    () => consoleText.ToString().ShouldContain(value),
                    () => consoleText.ToString().Count(c => c == Environment.NewLine.First()).ShouldBe(4)
                    });
                }
            }

        }
    }
}
