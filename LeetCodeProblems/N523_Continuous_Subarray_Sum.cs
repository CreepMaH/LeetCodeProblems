namespace LeetCodeProblems
{
    public class N523_Continuous_Subarray_Sum
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return false;
            }

            int[] sums = new int[nums.Length];
            sums[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }

            int[] rests = new int[sums.Length];
            for (int i = 0; i < sums.Length; i++)
            {
                int rest = sums[i] % k;
                if (rests.Contains(rest))
                {
                    return true;
                }
                else
                {
                    rests[i] = rest;
                }
            }

            return false;
        }
    }
}
