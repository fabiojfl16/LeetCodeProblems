using LeetCode.LinkedLists;

namespace LeetCode.Tests.LinkedLists;

public class ReverseLinkedList206Test
{
    [Fact]
    public void ShouldReverseListWithTwoElements()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));
        var expected = new ListNode(2, new ListNode(1));
        var reverseLinkedList = new ReverseLinkedList206();

        // Act
        var actual = reverseLinkedList.ReverseListIterative(head);

        // Assert
        var item = actual;
        var itemExpected = expected;

        while (itemExpected != null)
        {
            Assert.Equal(itemExpected.val, item.val);
            item = item.next;
            itemExpected = itemExpected.next;
        }
    }

    [Fact]
    public void ShouldReverseListWithMultipleElements()
    {
        // Arrange
        var head = new ListNode(1, 
                    new ListNode(2, 
                    new ListNode(3)));

        var expected = 
                    new ListNode(3,
                    new ListNode(2,
                    new ListNode(1)));

        var reverseLinkedList = new ReverseLinkedList206();

        // Act
        var actual = reverseLinkedList.ReverseList(head);

        // Assert
        var item = actual;
        var itemExpected = expected;

        while (itemExpected != null)
        {
            Assert.Equal(itemExpected.val, item.val);
            item = item.next;
            itemExpected = itemExpected.next;
        }
    }

    [Fact]
    public void ShouldReturnNullForNullList()
    {
        // Arrange
        var reverseLinkedList = new ReverseLinkedList206();

        // Act
        var actual = reverseLinkedList.ReverseList(null);

        // Assert
        Assert.Null(actual);
    }
}