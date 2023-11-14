namespace LeetCode.Stacks;

public class MinStack155
{
    private readonly List<int> stack;
    private readonly List<int> minStack;

    public MinStack155()
    {
        stack = new List<int>();
        minStack = new List<int>();
    }

    public void Push(int val)
    {
        stack.Add(val);

        if (minStack.Count == 0)
        {
            minStack.Add(val);
        }
        else
        {
            int minValue = minStack[^1] >= val ? val : minStack[^1];
            minStack.Add(minValue);
        }
    }

    public void Pop()
    {
        if (stack.Count > 0)
        {
            stack.RemoveAt(stack.Count - 1);
        }

        if (minStack.Count > 0)
        {
            minStack.RemoveAt(minStack.Count - 1);
        }
    }

    public int Top()
    {
        if (stack.Count > 0)
        {
            return stack[^1];
        }

        return -1;
    }

    public int GetMin()
    {
        if (minStack.Count > 0)
        {
            return minStack[^1];
        }

        return -1;
    }
}