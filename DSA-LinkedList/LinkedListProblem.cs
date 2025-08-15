namespace DSA_LinkedList;
public class LinkedListProblem
{

    /*
    *  https://leetcode.com/problems/linked-list-cycle/description/
    *  Linked List Cycle
    */
    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;

        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                return true;
            }
        }
        return false;
    }
    /*
     *  https://leetcode.com/problems/linked-list-cycle-ii/description/
     *  Linked List Cycle II
     */
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null)
            return null;

        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                var temp = head;
                while (temp != slow)
                {
                    temp = temp.next;
                    slow = slow.next;
                }
                return temp;
            }
        }
        return null;
    }
    /*
    *  https://leetcode.com/problems/reverse-linked-list/
    *  Reverse Linked List
    */
    //public ListNode ReverseList(ListNode head)
    //{
    //    ListNode prev = null;
    //    ListNode current = head;
    //    while (current != null)
    //    {
    //        ListNode temp = current.next;
    //        current.next = prev;
    //        prev = current;
    //        current = temp;
    //    }
    //    head = prev;
    //    return head;
    //}
    /*
     * https://leetcode.com/problems/add-two-numbers/
     * Add Two Numbers
     */
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        int value = 0;

        ListNode head = null;
        ListNode prev = null;
        ListNode current = null;
        while (l1 != null || l2 != null || carry != 0)
        {
            value = carry;
            if (l1 != null)
            {
                value += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                value += l2.val;
                l2 = l2.next;
            }

            carry = value / 10;
            value = value % 10;

            current = new ListNode(value);

            if (prev == null)
            {
                head = current;
            }
            else
            {
                prev.next = current;
            }
            prev = current;
        }
        return head;
    }
    /*
     * https://leetcode.com/problems/remove-nth-node-from-end-of-list/
     * Remove Nth Node From End of List
     */
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode slow = dummy;
        ListNode fast = dummy;

        for (int i = 0; i <= n; i++)
        {
            fast = fast.next;
        }

        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
    /*
     * https://leetcode.com/problems/merge-two-sorted-lists/description/
     * Merge Two Sorted Lists
     */
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        current.next = list1 ?? list2;
        return dummy.next;
    }
}