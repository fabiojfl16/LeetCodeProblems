namespace LeetCode.LinkedLists;

/// <summary>
/// Definition for singly-linked list.
/// </summary>
public class SinglyLinkedList
{
    public int val;
    public SinglyLinkedList next;

    public SinglyLinkedList(int val = 0, SinglyLinkedList next = null)
    {
        this.val = val;
        this.next = next;
    }
}