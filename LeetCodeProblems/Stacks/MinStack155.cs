namespace LeetCode.Stacks;

public class MinStack155
{
    private readonly List<int> stack;

    public MinStack155()
    {
        stack = new List<int>();
    }

    public void Push(int val)
    {
        stack.Add(val);
    }

    public void Pop()
    {
        if (stack.Count > 0)
        {
            stack.RemoveAt(stack.Count - 1);
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
        if (stack.Count > 0)
        {
            return stack.Min();
        }

        return -1;
    }
}