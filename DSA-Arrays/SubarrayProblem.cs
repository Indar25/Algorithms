namespace DSA_Arrays;
internal class SubarrayProblem
{
    /*
     * https://leetcode.com/problems/maximum-subarray/description/
     * 53. Maximum Subarray
     */
    public int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0];

        if (nums.Length == 1)
        {
            return maxSum;
        }
        int tempSum = maxSum;
        for (int i = 1; i < nums.Length; i++)
        {
            tempSum = nums[i] + Math.Max(tempSum, 0);
            maxSum = Math.Max(maxSum, tempSum);
        }
        return maxSum;
    }
}

