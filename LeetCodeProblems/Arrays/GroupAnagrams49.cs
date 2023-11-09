namespace LeetCode.Arrays;

public class GroupAnagrams49
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // string Hash and Anagrams
        var groups = new Dictionary<string, IList<string>>();

        foreach (string word in strs)
        {
            string wordLowerCase = word.ToLower();
            char[] hash = new char[26];
            
            foreach (char character in wordLowerCase)
            {
                hash[character - 'a']++;
            }

            string key = new(hash);
            
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            
            groups[key].Add(wordLowerCase);
        }

        return groups.Values.ToList();
    }
}