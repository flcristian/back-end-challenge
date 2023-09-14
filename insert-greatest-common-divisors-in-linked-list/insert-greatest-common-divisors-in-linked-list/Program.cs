using System;

internal class Program
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public int GreatestCommonDivisor(int x, int y)
        {
            while(x != y)
            {
                if(x > y)
                {
                    x -= y;
                }
                else
                {
                    y -= x;
                }
            }

            return x;
        }

        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode node = head;

            while (node.next != null)
            {
                ListNode toAdd = new ListNode(GreatestCommonDivisor(node.val, node.next.val), node.next);
                node.next = toAdd;

                node = node.next.next;
            }

            return head;
        }
    }

    private static void Main(string[] args)
    {
        int[] nr = { 18, 6, 10, 3 };
        ListNode head = null;
        int i = nr.Length - 1;
        while(i > -1)
        {
            head = new ListNode(nr[i], head);
            i--;
        }

        Solution sol = new Solution();
        sol.InsertGreatestCommonDivisors(head);

        while (head != null)
        {
            Console.WriteLine(head.val);
            head = head.next;
        }
    }
}