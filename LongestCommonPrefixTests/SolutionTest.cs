using FluentAssertions;
using LongestCommonPrefix;
using Xunit;

namespace LongestCommonPrefixTests;

public class SolutionTest {

    private readonly Solution _sol;

    public SolutionTest() {
        _sol = new Solution();
    }

    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void Test(string[] data, string res) {
        _sol.LongestCommonPrefix(data).Should().Be(res);
    }
}