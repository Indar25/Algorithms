namespace DSA_Arrays;
internal class ArrayRotate
{
    /*
     * https://leetcode.com/problems/rotate-array/submissions/1628535844/
     * 189. Rotate Array
     */
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n;
        RotateArray(nums, 0, n - 1);
        RotateArray(nums, 0, k - 1);
        RotateArray(nums, k, n - 1);

    }
    private void RotateArray(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}

