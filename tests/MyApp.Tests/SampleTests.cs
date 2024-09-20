using Xunit;
using FluentAssertions;

namespace MyApp.Tests  // Use sourceName here
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
            result.Should().Be(2);  // This is a simple test that checks if 1 + 1 equals 2
        }
    }
}
