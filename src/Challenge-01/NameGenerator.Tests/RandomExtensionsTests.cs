using System;
using Moq;
using Xunit;

namespace NameGenerator.Tests
{
    public class RandomExtensionsTests
    {
        public static TheoryData<int, string, string[]> PickData = new TheoryData<int, string, string[]>
        {
            {0, "a", new[] {"a", "b", "c"}},
            {1, "b", new[] {"a", "b", "c"}},
            {2, "c", new[] {"a", "b", "c"}}
        };

        [Theory]
        [MemberData(nameof(PickData))]
        public void Pick_ShouldHaveExpectedValue(int nextValue, string expectedValue, string[] values)
        {
            // Arrange
            var random = new Mock<Random>();
            random.Setup(r => r.Next(It.IsAny<int>())).Returns(nextValue);

            // Act
            string value = random.Object.Pick(values);

            // Assert
            Assert.Equal(expectedValue, value);
            random.Verify(r => r.Next(It.Is<int>(maxValue => maxValue == values.Length)));
        }

        public static TheoryData<int, bool> NextBoolData = new TheoryData<int, bool>
        {
            {0, false},
            {1, true}
        };

        [Theory]
        [MemberData(nameof(NextBoolData))]
        public void NextBool_ShouldHaveExpectedValue(int nextValue, bool expectedValue)
        {
            // Arrange
            var random = new Mock<Random>();
            random.Setup(r => r.Next(It.IsAny<int>())).Returns(nextValue);

            // Act
            bool value = random.Object.NextBool();

            // Assert
            Assert.Equal(expectedValue, value);
            random.Verify(r => r.Next(It.Is<int>(maxValue => maxValue == 2)));
        }
    }
}