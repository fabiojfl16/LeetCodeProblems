using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays;

public class GroupAnagrams49Test
{
    [Fact]
    public void ShouldGroupAnagrams()
    {
        // Arrange
        var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        var groupAnagram = new GroupAnagrams49();
        var groups = groupAnagram.GroupAnagrams(strs);

        // Assert
        Assert.Equal(3, groups.Count);
        
        Assert.Equal("eat", groups[0][0]);
        Assert.Equal("tea", groups[0][1]);
        Assert.Equal("ate", groups[0][2]);

        Assert.Equal("tan", groups[1][0]);
        Assert.Equal("nat", groups[1][1]);

        Assert.Equal("bat", groups[2][0]);
    }


    [Fact]
    public void ShouldGroupEmptyString()
    {
        // Arrange
        var strs = new string[] { "" };

        // Act
        var groupAnagram = new GroupAnagrams49();
        var groups = groupAnagram.GroupAnagrams(strs);

        // Assert
        Assert.Equal(1, groups.Count);
        Assert.Equal("", groups[0][0]);
    }

    [Fact]
    public void ShouldGroupSingleString()
    {
        // Arrange
        var strs = new string[] { "a" };

        // Act
        var groupAnagram = new GroupAnagrams49();
        var groups = groupAnagram.GroupAnagrams(strs);

        // Assert
        Assert.Equal(1, groups.Count);
        Assert.Equal("a", groups[0][0]);
    }
}