namespace DSA_LinkedList;
internal class Program
{
    static void Main(string[] args)
    {
        // Create nodes
        ListNode head = new ListNode(1);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(3);
        ListNode node4 = new ListNode(4);
        ListNode node5 = new ListNode(5);
        // Link them
        head.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;

        //var cyclicLinkedList = CreateCyclicLinkedList();

        LinkedListProblem problem = new LinkedListProblem();
        //Console.WriteLine(problem.HasCycle(cyclicLinkedList));

        //var result = problem.ReverseList(head);
        //var result = problem.RemoveNthFromEnd(head, 2);

        var list1 = new ListNode(1);
        list1.next = new ListNode(3);
        list1.next.next = new ListNode(5);

        var list2 = new ListNode(2);
        list2.next = new ListNode(4);
        list2.next.next = new ListNode(6);

        var result = problem.MergeTwoLists11(list1, list2);
        Console.ReadKey();
    }
    public static ListNode CreateCyclicLinkedList()
    {
        // Create nodes
        ListNode head = new ListNode(1);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(3);
        ListNode node4 = new ListNode(4);
        ListNode node5 = new ListNode(5);

        // Link them
        head.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;

        // Create cycle - node5 points back to node3
        node5.next = node3;

        return head;
    }
}

