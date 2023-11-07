using LeetCodeProblems.Arrays;

namespace LeetCode.Tests.Arrays;

public class ValidAnagram242Test
{
    [Fact]
    public void IsValidAnagram_242()
    {
        // Arrange
        string s = "anagram";
        string t = "nagaram";

        // Act
        var anagram = new ValidAnagram242();
        bool isAnagram = anagram.IsAnagram(s, t);

        // Assert
        Assert.True(isAnagram);
    }

    [Fact]
    public void IsNotValidAnagram_242()
    {
        // Arrange
        string s = "rat";
        string t = "car";

        // Act
        var anagram = new ValidAnagram242();
        bool isAnagram = anagram.IsAnagram(s, t);

        // Assert
        Assert.False(isAnagram);
    }
}