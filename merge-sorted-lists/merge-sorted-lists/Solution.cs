namespace merge_sorted_lists;

public class Solution
{
    public ListNode RemoveLast(ListNode list)
    {
        if (list == null! || list.next == null!)
        {
            return null;
        }

        ListNode current = list;
        while (current.next.next != null)
        {
            current = current.next;
        }

        current.next = null;

        return list;
    }
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode node = new ListNode();
        ListNode head = node;
        ListNode i = list1;
        ListNode j = list2;
        while (i != null! && j != null!)
        {
            head.next = new ListNode();
            if (i.val <= j.val)
            {
                head.val = i.val;
                head = head.next;
                i = i.next;
            }
            else
            {
                head.val = j.val;
                head = head.next;
                j = j.next;
            }
        }

        while (i != null)
        {
            head.next = new ListNode();
            head.val = i.val;
            head = head.next;
            i = i.next;
        }
        while (j != null)
        {
            head.next = new ListNode();
            head.val = j.val;
            head = head.next;
            j = j.next;
        }

        ListNode result = RemoveLast(node);
        
        return result;
    }
}