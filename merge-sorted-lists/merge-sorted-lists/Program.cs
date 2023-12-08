using merge_sorted_lists;

internal class Program
{
    public static void Main(string[] args)
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
        Solution sol = new Solution();
        ListNode result = sol.MergeTwoLists(list1, list2);

        ListNode head = result;
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
    }
}