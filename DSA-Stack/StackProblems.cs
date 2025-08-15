namespace DSA_Stack
{
    public class StackProblems
    {
        /* https://leetcode.com/problems/valid-parentheses/description/
         *  Valid Parentheses
         */

        public bool IsValid(string s)
        {
            Dictionary<char, char> map = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                else if (map.ContainsValue(s[i]))
                {
                    if (stack.Count == 0 || stack.Pop() != map[s[i]])
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        /* 
         * https://leetcode.com/problems/daily-temperatures/description/
         * Daily Temperatures
         */
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] result = new int[temperatures.Length];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < temperatures.Length; i++)
            {

                while (stack.Count > 0 || temperatures[i] > stack.Peek())
                {
                    int prevIndex = stack.Pop();
                    result[prevIndex] = i - prevIndex;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
