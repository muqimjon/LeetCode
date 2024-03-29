﻿using Fundamental;

namespace FundamentalEasy.Test;

public class LinkedListsTest
{
    // Arrange
    public readonly LinkedLists Solution = new();

    #region Create LinkedList <<
    private static ListNode CreateLinkedList(int[] arr)
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
    private int[] ConvertLinkedListToArray(ListNode head)
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
        ListNode list1 = CreateLinkedList(arr1);
        ListNode list2 = CreateLinkedList(arr2);

        // Act
        ListNode result = Solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(expectedArr, ConvertLinkedListToArray(result));
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
        ListNode head = CreateLinkedList(inputArray);

        // Act
        ListNode result = Solution.DeleteDuplicates(head);

        // Assert
        Assert.Equal(expectedArray, ConvertLinkedListToArray(result));
    }
    #endregion
}
