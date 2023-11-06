namespace LeetCode.LinkedLists;

public class ReverseLinkedList206
{
    public ListNode ReverseListIterative(ListNode head)
    {
        if (head == null)
            return null;

        ListNode previous = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }

    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return null;

        var newHead = head;

        if (head.next != null)
        {
            newHead = ReverseList(head.next);
            head.next.next = head;
        }
        
        head.next = null;
        return newHead;
    }
}