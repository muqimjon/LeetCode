using System.Linq;

namespace EasyFundamental;

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
    /// <time>Runtime: O(n)</time>
    /// <space>Memory: O(1)</space>
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head is null)
            return null!;

        var current = head;

        while (head.next is not null)
            if (head.val.Equals(head.next.val))
                head.next = head.next.next;
            else
                head = head.next;

        return current;
    }
    #endregion

    #region 234. Palindrome Linked List >>
    /// <summary>
    /// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
    /// </summary>
    /// <param name="head">The head of the singly linked list.</param>
    /// <returns>True if the linked list is a palindrome, false otherwise.</returns>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public bool IsPalindrome(ListNode head)
    {
        Stack<int> stack = new();

        stack.Push(head.val);

        while ((head = head!.next) is not null)
            stack.Push(head.val);

        return stack.SequenceEqual(stack.Reverse());
    }

    //public bool IsPalindrome(ListNode head)
    //{
    //    List<int> ls = [head.val], sl = [head.val];
    //    while ((head = head!.next) is not null)
    //    {
    //        ls.Insert(0, head.val);
    //        sl.Add(head.val);
    //    }
    //    return ls.SequenceEqual(sl);
    //}
    #endregion
}

#region ListNode Model <<
public class ListNode(int val = 0, ListNode next = null!)
{
    public int val = val;
    public ListNode next = next;
}
#endregion