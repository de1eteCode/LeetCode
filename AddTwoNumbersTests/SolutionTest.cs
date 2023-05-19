using FluentAssertions;
using Xunit;

namespace AddTwoNumbersTests;

public class SolutionTest {

    private readonly Solution _sol;

    public SolutionTest() {
        _sol = new Solution();
    }

    [Theory]
    [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [InlineData(new[] { 5, 6 }, new[] { 5, 4, 9 }, new[] { 0, 1, 0, 1 })]
    [InlineData(new[] { 9 }, new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    [InlineData(new[] { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 }, new[] { 5,6,4 }, new[] { 6,6,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 })]
    public void Test1(int[] l1, int[] l2, int[] result) {
        var res = _sol.AddTwoNumbers(ConvertToNode(l1), ConvertToNode(l2));
        var arr = ConvertFromNode(res).ToArray();
        arr.Should().BeEquivalentTo(result);
    }

    private static ListNode ConvertToNode(params int[] array) {
        if (array.Length == 1) {
            return new ListNode(array.First());
        }
        else {
            return new ListNode(array.First(), ConvertToNode(array.Skip(1).ToArray()));
        }
    }

    private static IEnumerable<int> ConvertFromNode(ListNode node) {
        if (node.next != null) {
            foreach (var num in ConvertFromNode(node.next)) {
                yield return num;
            }
        }

        yield return node.val;
    }
}