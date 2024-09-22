using Xunit;
using FluentAssertions;

namespace MyApp.Tests
{
    public class SampleTests
    {
        [Fact]
        public void DefaultTest_ShouldPass()
        {
            // Arrange
            var value = 1;

            // Act
            var result = value + 1;

            // Assert
            result.Should().Be(2);
        }
    }
}
