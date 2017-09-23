using NUnit.Framework;
using Shouldly;

namespace BridgePattern.Formatters
{
    [TestFixture]
    public class FancyFormatterTests
    {
        public class FormatShould
        {
            [Test]
            [TestCase("", "", "-=  ------- =- ")]
            [TestCase("test", "", "-= test ------- =- ")]
            [TestCase("", "value", "-=  ------- =- value")]
            [TestCase("%$%", "***", "-= %$% ------- =- ***")]
            public void GivenAKeyAndValue_ShouldReturnAFancyString(string key, string value, string expected)
            {
                //Arrange
                var sut = new FancyFormatter();
                //Act
                var result = sut.Format(key, value);
                //Assert
                result.ShouldBe(expected);
            }
        }
    }
}
