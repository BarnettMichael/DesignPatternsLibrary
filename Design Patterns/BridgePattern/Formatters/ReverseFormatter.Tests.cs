using NUnit.Framework;
using Shouldly;

namespace BridgePattern.Formatters
{
    [TestFixture]
    public class ReverseFormatterTests
    {
        public class FormatShould
        {
            [Test]
            [TestCase("", "", ": ")]
            [TestCase("test", "", "tset: ")]
            [TestCase("", "value", ": eulav")]
            [TestCase("tonsisiht", "emordnilapa", "thisisnot: apalindrome")]
            public void GivenAKeyAndValue_ShouldReverseTheStrings(string key, string value, string expected)
            {
                //Arrange
                var sut = new ReverseFormatter();
                //Act
                var result = sut.Format(key, value);
                //Assert
                result.ShouldBe(expected);
            }
        }
    }
}
