using Challenges.Arrays;
using Xunit;

namespace Challenges.Tests.Arrays
{
    public class ReverseTests
    {
        [Fact]
        public void ReverseArray_reverses_an_empty_array()
        {
            // Arrange
            int[] array = new int[0];

            // Act
            int[] result = Reverse.ReverseArray(array);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ReverseArray_reverse_a_nonempty_array()
        {
            // Arrange
            int[] arrayToReverse = new[] { 1, 2, 3 };

            // Act
            int[] result = Reverse.ReverseArray(arrayToReverse);

            // Assert
            int[] expected = new[] { 3, 2, 1 };
            Assert.Equal(expected, result);
        }
    }
}
