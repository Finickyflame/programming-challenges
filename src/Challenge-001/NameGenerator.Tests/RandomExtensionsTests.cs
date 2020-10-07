using System;
using Moq;
using Xunit;

namespace NameGenerator.Tests
{
    public class RandomExtensionsTests
    {
        [Fact]
        public void Pick_ShouldReturnItem()
        {
            // Arrange
            var random = new Mock<Random>();
            random.Setup(r => r.Next(It.IsAny<int>()))
                .Returns(1);

            // Act

            // Assert
        }
    }
}