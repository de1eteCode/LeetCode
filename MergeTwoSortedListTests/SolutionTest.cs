using FluentAssertions;
using MergeTwoSortedList;
using Xunit;

namespace MergeTwoSortedListTests;

public class SolutionTest {

    private readonly Solution _sol;

    public SolutionTest() {
        _sol = new Solution();
    }

    [Theory]
    [InlineData(new[] { 1,2,4 }, new[] { 1,3,4 }, new[] { 1,1,2,3,4,4 })]
    public void Test1(int[] l1, int[] l2, int[] result) {
        ConvertFromNode(_sol.MergeTwoLists(ConvertToNode(l1), ConvertToNode(l2))).Should().BeEquivalentTo(result);
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