using EasyFundamental;

namespace EasyFundamentalTest;

public class LinkedListsTest
{
    // Arrange
    public readonly LinkedLists Solution = new();

    #region Create LinkedList <<
    private static ListNode BuildLinkedList(int[] arr)
    {
        ListNode dummy = new(0);
        ListNode current = dummy;
        foreach (int val in arr)
        {
            current.next = new ListNode(val);
            current = current.next;
        }
        return dummy.next;
    }
    #endregion

    #region Convert LinkedList To Array <<
    private int[] LinkedListToArray(ListNode head)
    {
        List<int> result = [];
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }

        return [.. result];
    }
    #endregion

    #region 21. Merge Two Sorted Lists >>
    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
    public void MergeTwoLists_ShouldReturnMergedSortedLinkedList(int[] arr1, int[] arr2, int[] expectedArr)
    {
        // Arrange
        ListNode list1 = BuildLinkedList(arr1);
        ListNode list2 = BuildLinkedList(arr2);

        // Act
        ListNode result = Solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(expectedArr, LinkedListToArray(result));
    }
    #endregion

    #region 83. Remove Duplicates from Sorted List Tests >>
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 1, 2, 3, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { }, new int[] { })] // Edge case: empty list
    [InlineData(new int[] { 1 }, new int[] { 1 })] // Edge case: list with one element
    [InlineData(new int[] { 1, 1, 1 }, new int[] { 1 })] // All elements are duplicates
    public void DeleteDuplicates_ShouldReturnCorrectList(int[] inputArray, int[] expectedArray)
    {
        // Arrange
        ListNode head = BuildLinkedList(inputArray);

        // Act
        ListNode result = Solution.DeleteDuplicates(head);

        // Assert
        Assert.Equal(expectedArray, LinkedListToArray(result));
    }
    #endregion

    #region 234. Palindrome Linked List >>
    [Theory]
    [InlineData(true, new[] { 1, 2, 2, 1 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(false, new[] { 1, 0, 0 })]
    [InlineData(true, new[] { 2, 4, 6, 4, 2 })]
    [InlineData(false, new[] { 1, 2, 3, 4 })]
    public void TestIsPalindrome(bool expected, int[] values)
    {
        // Arrange
        ListNode head = BuildLinkedList(values);

        // Act
        bool result = Solution.IsPalindrome(head);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 206. Reverse Linked List >>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void TestReverseList(int[] inputValues, int[] expectedValues)
    {
        // Arrange
        ListNode head = BuildLinkedList(inputValues);

        // Act
        ListNode result = Solution.ReverseList(head);

        // Assert
        Assert.Equal(expectedValues, LinkedListToArray(result));
    }
    #endregion

    #region 1290. Convert Binary Number in a Linked List to Integer
    [Theory]
    [InlineData(new int[] { 1, 0, 1 }, 5)]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 1, 1 }, 7)]
    [InlineData(new int[] { 1, 0, 0, 1, 1 }, 19)]
    public void GetDecimalValueTests(int[] list, int expected)
    {
        // Arrange
        ListNode head = BuildLinkedList(list);

        // Act
        int result = Solution.GetDecimalValue(head);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 876. Middle of the Linked List
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6 })]
    public void TestMiddleNode(int[] head, int[] expected)
    {
        // Arrange
        ListNode headNode = BuildLinkedList(head);

        // Act
        ListNode resultNode = Solution.MiddleNode(headNode);

        // Convert the resulting linked list to an array for easy comparison
        int[] resultArray = LinkedListToArray(resultNode);

        // Assert
        Assert.Equal(expected, resultArray);
    }
    #endregion
}
