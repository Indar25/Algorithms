namespace DSA_Strings;
public class StringProblems
{
    public IList<string> CommonChars(string[] words)
    {
        int[] commonCount = new int[26];
        Array.Fill(commonCount, int.MaxValue);

        List<string> chars = new List<string>();
        foreach (string word in words)
        {
            int[] charCount = new int[26];
            foreach (int c in word)
            {
                charCount[c - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                commonCount[i] = Math.Min(commonCount[i], charCount[i]);
            }
        }

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < commonCount[i]; j++)
            {
                chars.Add(((char)(i + 'a')).ToString());
            }
        }

        return chars;
    }
}
