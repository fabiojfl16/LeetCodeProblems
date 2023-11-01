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

        bool isAnagram = ValidAnagram242.IsAnagram(s, t);
        Assert.True(isAnagram);
    }

    [Fact]
    public void IsNotValidAnagram_242()
    {
        // Arrange
        string s = "rat";
        string t = "car";

        bool isAnagram = ValidAnagram242.IsAnagram(s, t);
        Assert.False(isAnagram);
    }
}