namespace LeetCodeProblems.Arrays;

public class ValidAnagram242
{
    public bool IsAnagram(string firstWord, string secondWord)
    {
        if (firstWord.Length != secondWord.Length)
            return false;

        var firstMap = new Dictionary<string, int>();
        var secondMap = new Dictionary<string, int>();

        for (int i = 0; i < firstWord.Length; i++)
        {
            string firstKey = firstWord[i].ToString();

            // Add the count of each character in the string
            if (firstMap.ContainsKey(firstKey))
                firstMap[firstKey] += 1;
            else
                firstMap.Add(firstKey, 1);

            string secondKey = secondWord[i].ToString();

            if (secondMap.ContainsKey(secondKey))
                secondMap[secondKey] += 1;
            else
                secondMap.Add(secondKey, 1);
        }

        foreach (string key in firstMap.Keys)
        {
            // Checks if firstWord and Second contains the same character and also the count of it.
            if (!secondMap.ContainsKey(key) || secondMap[key] != firstMap[key])
                return false;
        }

        return true;
    }
}