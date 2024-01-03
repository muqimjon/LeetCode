namespace Easy;

public class LinkedLists
{
    #region 21. Merge Two Sorted Lists >>
    /// <summary>
    /// 21. Merge Two Sorted Lists
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val) (current.next, list1) = (list1, list1.next);
            else (current.next, list2) = (list2, list2.next);

            current = current.next;
        }

        current.next = list1 ?? list2!;

        return dummy.next;
    }

    #endregion
}

#region 21. Merge Two Sorted Lists <<
public class ListNode(int val = 0, ListNode next = null!)
{
    public int val = val;
    public ListNode next = next;
}
#endregion