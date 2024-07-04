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

    #region 206. Reverse Linked List >>
    /// <summary>
    /// Reverses a singly linked list.
    /// </summary>
    /// <param name="head">The head of the singly linked list.</param>
    /// <returns>The head of the reversed linked list.</returns>
    /// <link>https://leetcode.com/problems/reverse-linked-list/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null!, current = head;

        while (current != null)
            (current.next, prev, current) = (prev, current, current.next);

        return prev;
    }
    #endregion

    #region 1290. Convert Binary Number in a Linked List to Integer
    /// <summary>
    /// Converts a binary number represented by a singly-linked list to an integer.
    /// </summary>
    /// <param name="head">The head node of the singly-linked list.</param>
    /// <returns>The decimal value of the binary number.</returns>
    /// <link>https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int GetDecimalValue(ListNode head)
    {
        int result = 0;

        while (head != null)
        {
            result = (result << 1) | head.val;
            head = head.next;
        }

        return result;
    }
    #endregion

    #region 876. Middle of the Linked List
    /// <summary>
    /// Returns the middle node of the list; if two middle nodes, returns the second.
    /// </summary>
    /// <param name="head">The head of the singly linked list.</param>
    /// <returns>The middle node of the list.</returns>
    /// <link>https://leetcode.com/problems/middle-of-the-linked-list/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public ListNode MiddleNode(ListNode head)
    {
        var slow = head;

        for (var fast = head; fast?.next != null; slow = slow.next, fast = fast.next.next) ;

        return slow;
    }
    #endregion

    #region 203. Remove Linked List Elements
    /// <summary>
    /// Removes all nodes with the given value from the linked list.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <param name="val">The value to remove from the linked list.</param>
    /// <returns>The head of the modified linked list.</returns>
    /// <link>https://leetcode.com/problems/remove-linked-list-elements/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new(0, head);

        for (var current = dummy; current.next is not null;)
            if (current.next.val.Equals(val))
                current.next = current.next.next;
            else
                current = current.next;

        return dummy.next;
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