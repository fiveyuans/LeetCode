using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._002
{
    class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int temp = 0;
            int sum = 0;
            ListNode nodeStart = null;
            ListNode node = null;
            ListNode zore = new ListNode(0);

            do
            {
                if (nodeStart == null)
                {
                    sum = l2.val + l1.val + temp;
                    node = nodeStart = new ListNode(sum % 10);
                }
                else
                {
                    l1 = l1.next == null ? zore : l1.next;
                    l2 = l2.next == null ? zore : l2.next;

                    sum = l2.val + l1.val + temp;
                    node = node.next = new ListNode(sum % 10);

                }
                temp = sum / 10;

            } while (l1.next != null || l2.next != null || temp != 0);


            return nodeStart;
        }
        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            int temp = 0;
            int sum = 0;
            ListNode nodeStart = null;
            ListNode node = null;
            ListNode zore = new ListNode(0);
            while (true)
            {

                if (nodeStart == null)
                {
                    sum = l2.val + l1.val + temp;

                    node = nodeStart = new ListNode(sum % 10);
                }
                else
                {
                    l1 = l1.next == null ? zore : l1.next;
                    l2 = l2.next == null ? zore : l2.next;

                    sum = l2.val + l1.val + temp;
                    node = node.next = new ListNode(sum % 10);

                }
                temp = sum / 10;
                if (l1.next == null && l2.next == null && temp == 0)
                    return nodeStart;
            };
        }
    }

    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
