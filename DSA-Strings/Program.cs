using System.Text;

namespace DSA_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubStringProblems sb = new SubStringProblems();
            //Console.WriteLine(sb.LengthOfLongestSubstring("abcabcbb"));

            //Console.WriteLine(string.Join(",", sb.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3)));
            //Console.WriteLine("Hello, World!");
            //var even = GetEvenNumbers(10);
            //foreach (var num in even)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.ReadKey();

            string[] str = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = GroupAnagrams(str);

            Console.ReadKey();
        }
        public static List<string> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var key = GetKey(strs[i]);

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }
                map[key].Add(strs[i]);
            }

            return map.Values.SelectMany(x => x).ToList();
        }

        private static string GetKey(string str)
        {
            int[] arr = new int[26];
            foreach (char c in str)
            {
                arr[c - 'a']++;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] > 0)
                    sb.Append((char)(i + 'a'));
            }
            return sb.ToString();
        }
    }
}
