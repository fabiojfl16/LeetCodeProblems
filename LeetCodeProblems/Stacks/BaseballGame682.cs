namespace LeetCode.Stacks;

public class BaseballGame682
{
    public int CalPoints(string[] operations)
    {
        Stack<int> stack = new();

        for (int i = 0; i < operations.Length; i++)
        {
            string op = operations[i];

            if(op == "+")
            {
                // Sum 2 previous values
                int second = stack.Pop();
                int first = stack.Pop();
                int sum = second + first;

                stack.Push(first);
                stack.Push(second);
                stack.Push(sum);
            }
            else if (op == "C")
            {
                // Remove last added item
                stack.Pop();
            }
            else if (op == "D")
            {
                // Multiply last item by 2
                int lastNumber = stack.Pop();
                stack.Push(lastNumber);
                stack.Push(lastNumber * 2);
            }
            else
            {
                // It's a number, so add it to the stack.
                int value = int.Parse(op);
                stack.Push(value);
            }
        }

        return stack.Sum();
    }
}