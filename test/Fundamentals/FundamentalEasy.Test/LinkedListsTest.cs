namespace FundamentalEasy.Test;

public class LinkedListsTest
{
    // Arrange
    public readonly LinkedLists Solution = new();

    #region 21. Merge Two Sorted Lists
    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
    public void MergeTwoLists_ShouldReturnMergedSortedLinkedList(int[] arr1, int[] arr2, int[] expectedArr)
    {
        // Arrange
        ListNode list1 = CreateLinkedList(arr1);
        ListNode list2 = CreateLinkedList(arr2);
        ListNode expected = CreateLinkedList(expectedArr);

        // Act
        ListNode result = Solution.MergeTwoLists(list1, list2);

        // Assert
        while (result is not null || expected is not null)
        {
            Assert.Equal(expected.val, result!.val);
            expected = expected.next;
            result = result.next;
        }
    }

    private static ListNode CreateLinkedList(int[] arr)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        foreach (int val in arr)
        {
            current.next = new ListNode(val);
            current = current.next;
        }
        return dummy.next;
    }
    #endregion
}
