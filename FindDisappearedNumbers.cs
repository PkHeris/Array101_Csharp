using System;

namespace Array101
{
    public class FindDisappearedNumbers
    {
        public IList<int> FindDisappearedNumbersInPlace(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }

            }
            int writerIndex = 0;
            for(int i = 0; i<n; i++)
            {
                if (nums[i] > 0)
                {
                    nums[writerIndex] = i + 1;
                    writerIndex++;
                }
            }
            return new ArraySegment<int>(nums, 0, writerIndex);
        }
    }
}
