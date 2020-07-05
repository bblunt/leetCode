public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int correspondingIdx = Array.IndexOf(nums, (target - nums[i]));
            if (correspondingIdx != -1 && correspondingIdx != i)
            {
                return new[] { i, correspondingIdx };
            }
        }
        return null;
    }
}