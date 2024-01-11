namespace Easy;

public class LinkedLists
{
    #region 21. Merge Two Sorted Lists >>
    /// <summary>
    /// Merges two sorted linked lists into a single sorted linked list.
    /// </summary>
    /// <param name="list1">The first sorted linked list.</param>
    /// <param name="list2">The second sorted linked list.</param>
    /// <returns>A new linked list containing the merged elements in sorted order.</returns>
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Create a dummy node to simplify the code
        ListNode dummy = new();
        // Create a reference to the current node
        var current = dummy;

        // Iterate until one of the lists is exhausted
        while (list1 is not null && list2 is not null)
        {
            // Compare the values of the current nodes of both lists
            if (list1.val < list2.val)
                // If the value in list1 is smaller, add it to the merged list
                (current.next, list1) = (list1, list1.next);
            else
                // If the value in list2 is smaller or equal, add it to the merged list
                (current.next, list2) = (list2, list2.next);

            // Move to the next node in the merged list
            current = current.next;
        }

        // Add the remaining nodes from the non-empty list
        current.next = list1 ?? list2!;

        // Return the merged list starting from the next of the dummy node
        return dummy.next;
    }

    #endregion

    #region 83. Remove Duplicates from Sorted List >>
    /// <summary>
    /// Given the head of a sorted linked list, delete all duplicates such that each element appears only once. 
    /// </summary>
    /// <param name="head">The head of the sorted linked list.</param>
    /// <returns>The head of the linked list after removing duplicates.</returns>
    /// <time>Runtime: O(n) - Linear time complexity, where n is the number of nodes in the linked list.</time>
    /// <space>Memory: O(1) - Constant space complexity, as no additional data structures are used.</space>
    public ListNode DeleteDuplicates(ListNode head)
    {
        // Check if the linked list is empty
        if (head is null)
            return null!;

        // Create a reference to the current node
        var current = head;

        // Iterate through the linked list
        while (head.next is not null)
            // Check if the current node's value is equal to the next node's value
            if (head.val.Equals(head.next.val))
                // Skip the next node by updating the current node's next pointer
                head.next = head.next.next;
            else
                // Move to the next node
                head = head.next;

        // Return the head of the modified linked list
        return current;
    }
    #endregion
}

#region ListNode Model <<
public class ListNode(int val = 0, ListNode next = null!)
{
    public int val = val;
    public ListNode next = next;
}
#endregion