namespace DSA_Strings;
internal class StringsProblems
{
    /*
     *https://leetcode.com/problems/permutation-in-string/description/
     *567. Permutation in String
     */
    public bool CheckInclusion(string s1, string s2)
    {
        int sourceLength = s1.Length;
        int targetLength = s2.Length;
        if (sourceLength > targetLength)
        {
            return false;
        }

        int[] source = new int[26];
        int[] target = new int[26];

        for (int i = 0; i < sourceLength; i++)
        {
            source[s1[i] - 'a']++;
        }

        for (int i = 0; i < s2.Length; i++)
        {
            target[s2[i] - 'a']++;

            if (i >= sourceLength)
                target[s2[i - sourceLength] - 'a']--;

            if (i >= sourceLength - 1 && IsEqual(source, target))
                return true;
        }

        return false;
    }

    private bool IsEqual(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i] != target[i])
                return false;
        }
        return true;
    }
    /*
     * 438. Find All Anagrams in a String
     * https://leetcode.com/problems/find-all-anagrams-in-a-string/description/
     */
    public IList<int> FindAnagrams(string s, string p)
    {
        int sLength = s.Length;
        int pLength = p.Length;

        List<int> result = new List<int>();

        if (pLength > sLength)
            return result;

        int[] sArray = new int[26];
        int[] pArray = new int[26];

        for (int i = 0; i < pLength; i++)
        {
            pArray[p[i] - 'a']++;
        }

        for (int i = 0; i < pLength; i++)
        {
            sArray[s[i] - 'a']++;
        }
        if (IsEqual(sArray, pArray))
            result.Add(0);

        for (int i = pLength; i < sLength; i++)
        {
            sArray[s[i] - 'a']++;
            sArray[s[i - pLength] - 'a']--;

            if (IsEqual(sArray, pArray))
            {
                result.Add(i - pLength + 1);
            }
        }

        return result;
    }
}
