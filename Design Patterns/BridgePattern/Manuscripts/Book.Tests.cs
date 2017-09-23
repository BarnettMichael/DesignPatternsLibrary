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
    public class BookTests
    {
        public class PrintShould
        {
            [Test]
            [TestCase("", "", "")]
            [TestCase("title", "author", "text")]
            [TestCase("Moby Dick", "Melville", "Whale Stuff")]
            [TestCase("Dune", "Frank Herbert", "The spice must flow")]
            [TestCase("Wwrd?", "Tim Riggins", "")]
            public void WithAFormatter_ShouldPrintAFormattedStringOfProperties(string title, string author, string text)
            {
                //Arrange
                var sut = new Book(new StandardFormatter());
                sut.Title = title;
                sut.Author = author;
                sut.Text = text;

                //Act
                using (var consoleText = new StringWriter())
                {
                    SetOut(consoleText);
                    sut.Print();
                    //Assert
                    consoleText.ToString().ShouldSatisfyAllConditions(new Action[]
                    {
                    () => consoleText.ToString().ShouldContain(title),
                    () => consoleText.ToString().ShouldContain(author),
                    () => consoleText.ToString().ShouldContain(text),
                    () => consoleText.ToString().Count(c => c == Environment.NewLine.First()).ShouldBe(4)
                    });
                }
            }

        }
    }
}

