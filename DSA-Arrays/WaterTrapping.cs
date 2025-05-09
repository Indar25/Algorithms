namespace DSA_Arrays;
internal class WaterTrapping
{
    /*
     * https://leetcode.com/problems/trapping-rain-water/description/
     * 42. Trapping Rain Water
     */
    public int Trap(int[] height)
    {
        int maxWater = 0;
        int left = 0;
        int right = height.Length - 1;
        int leftMax = -1;
        int rightMax = -1;
        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] > leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    maxWater += leftMax - height[left];
                }

                left++;
            }
            else
            {
                if (height[right] > rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    maxWater += rightMax - height[right];
                }
                right--;
            }
        }

        return maxWater;
    }
    /*
     * https://leetcode.com/problems/container-with-most-water/
     * 11. Container With Most Water
     */
    public int MaxArea(int[] height)
    {
        int maxWater = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int minHeight = Math.Min(height[left], height[right]);

            maxWater = Math.Max(maxWater, width * minHeight);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxWater;
    }
}

