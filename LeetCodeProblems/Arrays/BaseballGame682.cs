namespace LeetCodeProblems.Arrays;

internal class BaseballGame682
{
    public static int CalPoints(string[] operations)
    {
        Stack<int> stack = new();

        for (int i = 0; i < operations.Length; i++)
        {
            string operation = operations[i];

            if (operation == "+")
            {
                int first = stack.Pop();
                int second = stack.Pop();

                int value = first + second;

                stack.Push(second);
                stack.Push(first);
                stack.Push(value);
            }
            else if (operation == "D")
            {
                int lastRecord = stack.Pop();
                stack.Push(lastRecord);
                stack.Push(2 * lastRecord);
            }
            else if (operation == "C")
            {
                stack.Pop();
            }
            else
            {
                stack.Push(int.Parse(operation));
            }
        }

        return stack.Sum();
    }
}