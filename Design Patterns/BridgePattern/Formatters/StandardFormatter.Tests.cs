using NUnit.Framework;
using Shouldly;

namespace BridgePattern.Formatters
{
    [TestFixture]
    public class StandardFormatterTests
    {
        public class FormatShould
        {
            [Test]
            [TestCase("", "", ": ")]
            [TestCase("test", "", "test: ")]
            [TestCase("", "value", ": value")]
            [TestCase("test", "value", "test: value")]
            public void GivenAKeyAndValue_ShouldReverseTheStrings(string key, string value, string expected)
            {
                //Arrange
                var sut = new StandardFormatter();
                //Act
                var result = sut.Format(key, value);
                //Assert
                result.ShouldBe(expected);
            }
        }
    }
}
