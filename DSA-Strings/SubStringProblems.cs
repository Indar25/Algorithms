namespace DSA_Strings;
class SubStringProblems
{
    /*
     * https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/1697299704/
     * Longest Substring Without Repeating Characters
     */
    public int LengthOfLongestSubstring(string s)
    {
        int maxLenght = 0;
        string str = string.Empty;
        Queue<char> queue = new Queue<char>();
        for (int i = 0; i < s.Length; i++)
        {
            while (queue.Contains(s[i]))
            {
                queue.Dequeue();
            }
            queue.Enqueue(s[i]);
            if (queue.Count > maxLenght)
            {
                maxLenght = queue.Count;
                str = string.Join("", queue);
            }
        }
        return maxLenght;
    }

    public int LengthOfLongestSubstring_HashSet(string s)
    {
        int maxLenght = 0;
        int left = 0, right = 0;

        HashSet<char> seen = new HashSet<char>();
        while (right < s.Length)
        {
            if (!seen.Contains(s[right]))
            {
                seen.Add(s[right]);
                maxLenght = Math.Max(maxLenght, right - left + 1);
                right++;
            }
            else
            {
                seen.Remove(s[right]);
                left++;
            }
        }
        return maxLenght;
    }
}
