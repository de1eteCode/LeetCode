using FluentAssertions;
using TwoSum;
using Xunit;

namespace TwoSumTests;

public class SolutionTest {

    private readonly Solution _sol;

    public SolutionTest() {
        _sol = new();
    }

    [Theory]
    [InlineData(new [] { 2, 7, 11, 15 }, 9, new [] { 0, 1 })]
    [InlineData(new [] { 3, 2, 4 }, 6, new [] { 1, 2 })]
    [InlineData(new [] { 3, 3 }, 6, new [] { 0, 1 })]
    [InlineData(new [] { 3, 1, 3 }, 6, new [] { 0, 2 })]
    public void Test(int[] nums, int target, int[] result) {
        _sol.TwoSum(nums, target).Should().BeEquivalentTo(result);
    }
}