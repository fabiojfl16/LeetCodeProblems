namespace LeetCode.Queue;

public class ValidParentheses20
{
    public bool IsValid(string input)
    {
        var stack = new Stack<char>();
        var closeToOpenMap = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in input)
        {
            if (!closeToOpenMap.ContainsKey(c))
            {
                // Adds only open items to the stack: '(', '{' or '['.
                stack.Push(c);
                continue;
            }
            else if (stack.Count == 0)
            {
                // If stack is empty that means the 'Open' item was not added before.
                return false;
            }

            // '(', '{' or '['
            var lastOpenItem = stack.Pop();

            // '(', '{' or '['
            var mapValue = closeToOpenMap[c];

            if (lastOpenItem != mapValue)
                return false;
        }

        return stack.Count == 0;
    }
}