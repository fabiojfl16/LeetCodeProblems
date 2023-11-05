using LeetCode.LinkedLists;

namespace LeetCode.Tests.LinkedLists;

public class ReverseLinkedList206Test
{
    [Fact]
    public void ShouldReverseListWithTwoElements()
    {
        // Arrange
        var head = new SinglyLinkedList(1, new SinglyLinkedList(2));
        var expected = new SinglyLinkedList(2, new SinglyLinkedList(1));

        // Act
        var actual = ReverseLinkedList206.ReverseList(head);

        // Assert
        var item = actual;
        var itemExpected = expected;

        while (itemExpected.next != null)
        {
            Assert.Equal(itemExpected.val, item.val);
            item = item.next;
            itemExpected = expected.next;
        }
    }

    [Fact]
    public void ShouldReverseListWithMultipleElements()
    {
        // Arrange
        var head = new SinglyLinkedList(1, 
                    new SinglyLinkedList(2, 
                    new SinglyLinkedList(3,
                    new SinglyLinkedList(4, 
                    new SinglyLinkedList(5)))));

        var expected = new SinglyLinkedList(5,
                    new SinglyLinkedList(4,
                    new SinglyLinkedList(3,
                    new SinglyLinkedList(2,
                    new SinglyLinkedList(1)))));

        // Act
        var actual = ReverseLinkedList206.ReverseList(head);

        // Assert
        var item = actual;
        var itemExpected = expected;

        while (itemExpected.next != null)
        {
            Assert.Equal(itemExpected.val, item.val);
            item = item.next;
            itemExpected = expected.next;
        }
    }
}