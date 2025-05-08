namespace DSA_Arrays;
internal class ProblemSlidingWindow
{
    /*
     * https://leetcode.com/problems/sliding-window-maximum/description/
     * 239. Sliding Window Maximum
     */
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int n = nums.Length;
        int[] result = new int[n - k + 1];

        LinkedList<int> ll = new LinkedList<int>();
        int index = -1;

        for (int i = 0; i < n; i++)
        {
            while (ll.Count > 0 && nums[ll.Last.Value] <= nums[i])
            {
                ll.RemoveLast();
            }
            ll.AddLast(i);

            if (ll.First.Value <= i - k)
                ll.RemoveFirst();

            if (i >= k - 1)
                result[++index] = nums[ll.First.Value];
        }
        return result;
    }
}
