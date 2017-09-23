using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AdapterPattern.Model
{
    [TestFixture]
    public class PatternRendererTests
    {
        public class RenderShould
        {
            [Test]
            public void GivenAPattern_RenderASinglePattern()
            {
                //Arrange
                var renderer = new PatternRenderer();
                var patterns = new List<Pattern>()
                {
                    new Pattern() {Id = 1, Name = "Pattern One", Description = "Pattern One Description"}
                };
                //Act
                var result = renderer.ListPatterns(patterns);
                //Assert
                Write(result);

                result.Count(c => c == '\n').ShouldBe(3);
            }
        }

    }
}
