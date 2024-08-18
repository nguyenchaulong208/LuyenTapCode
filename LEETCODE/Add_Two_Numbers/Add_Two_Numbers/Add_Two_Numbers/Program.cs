
using System.Collections.Generic;
using System.Security.Authentication;
using System.Xml.Linq;

namespace Add_Two_Sum
{
    public class Algorithm
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummyHead = new ListNode(0);//con trỏ Head trỏ vào node 0
                ListNode p = l1, q = l2, curr = dummyHead;// Tạo con trỏ p và q trỏ vào các node của các danh sách liên kết
                int carry = 0;
                while (p != null || q != null)
                {
                    //int x = (p != null) ? p.val : 0;
                    int x;
                    if (p != null)
                    {
                        x = p.val;
                    }
                    else
                    {
                        x = 0;
                    }
                    //int y = (q != null) ? q.val : 0;
                    int y;
                    if (q != null)
                    {
                        y = q.val;
                    }
                    else
                    {
                        y = 0;
                    }
                    int sum = carry + x + y;
                    carry = sum / 10;
                    curr.next = new ListNode(sum % 10);
                    curr = curr.next;
                    if (p != null) p = p.next;
                    if (q != null) q = q.next;
                }
                if (carry > 0)
                {
                    curr.next = new ListNode(carry);
                }
                return dummyHead.next;

            }

        }
        public static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
        

        public static void Main(string[] args)
        {
            
           ListNode head = new ListNode(7);
            head.next = new ListNode(5);
            head.next.next = new ListNode(9);
            head.next.next.next = new ListNode(6);
            head.next.next.next.next = new ListNode(4);
            Console.Write("Second list is ");
            PrintList(head);

            ListNode head2 = new ListNode(8);
            head2.next = new ListNode(4);
            Console.Write("Second list is ");
            PrintList(head2);
            Solution solution = new Solution();
            ListNode result = solution.AddTwoNumbers(head, head2);
            PrintList(result);
        }

    }
    
    
}
