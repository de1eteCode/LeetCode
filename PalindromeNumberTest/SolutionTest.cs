using FluentAssertions;
using PalindromeNumber;
using Xunit;

namespace PalindromeNumberTest;

public class SolutionTest {

    private readonly Solution _sol;

    public SolutionTest() {
        _sol = new Solution();
    }

    [Theory]
    [InlineData(121, true)]
    [InlineData(122, false)]
    [InlineData(22, true)]
    [InlineData(-22, false)]
    public void Test(int num, bool res) {
        _sol.IsPalindrome(num).Should().Be(res);
    }
}